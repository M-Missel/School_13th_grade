using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using kNN;

namespace knn {
  public enum Mode {POINT, KNN}

  public class Steuerung {
    private GUI dieGUI;
    private List<Feature> features;
    private int num_features;
    private PlotImage I_Schaubild;
    private Mode currentMode;
    private List<Punkt> points;
    private int activatePointNum;
    private string filename;

    public string Filename {
      get { return filename; }
      set
      {
        filename = value;
        if (filename != "") {
          dieGUI.setTitle("kNN- und kMeans-Simulator [" + filename.Substring(filename.LastIndexOf('/') + 1) + "]");
        } else {
          dieGUI.setTitle("kNN- und kMeans-Simulator [Neue Datei]");
        }
      }
    }

    public Steuerung(GUI pGUI) {
      dieGUI = pGUI;
      features = new List<Feature>();
      num_features = 0;
      points = new List<Punkt>();
      Filename = "";
      currentMode = Mode.KNN;
      changekNNMode();
    }

    internal void checkArgs() {
      string[] argv = Environment.GetCommandLineArgs();
      if (argv.Length > 1) {
        dieGUI.loadFile(argv[1]);
      } else {
        Filename = "";
      }
    }

    public void newFeature() {
      dieGUI.newFeature(num_features);
      num_features = num_features + 1;
      features.Add(new Feature(dieGUI.getFeatureName(num_features-1))); 
    }

    public void drawAll(Graphics g) {
      dieGUI.setcoordSize();
      dieGUI.drawCoordsAndGrid(g);
      this.updatePoints();
      this.drawPoints(g);
    }

    public void makeImageAssoc(PlotImage p_ImageFunc) {
      I_Schaubild = p_ImageFunc;
    }

    public int getFeatureNum() {
      return num_features;
    }

    public void updatePoints() {
      string point_str;
      for (int i = 0; i < points.Count; i++) {
        Punkt point = points[i];
        if (point.IsLabelPoint()) {
          int labelNum = point.getFeatureNum();
          point.setColor(dieGUI.getFeatureColor(labelNum));
          point_str = point.getCoordString();
          dieGUI.changePointListBox(i, point_str);
        }
      }
    }

    private void drawPoints(Graphics g) {
      foreach (Punkt p in points) {
        p.drawPoint(I_Schaubild, g);
      }
    }

    public void changekNNMode() {
      switch (currentMode) {
        case Mode.POINT: currentMode = Mode.KNN;   break;
        case Mode.KNN:   currentMode = Mode.POINT; break;
        default: throw new NotImplementedException();
      }
      dieGUI.showMode(currentMode);
    }

    public Mode getkNNMode() {
      return currentMode;
    }

    internal void addPoint(double x, double y, int feature_num) {
      points.Add(new Punkt(x, y, features[feature_num], feature_num, dieGUI.getFeatureColor(feature_num)));
      dieGUI.addPointListbox(points.Last<Punkt>().getCoordString());
    }

    public void addPointByClick(double x, double y, int feature_num) {
      addPoint(x, y, feature_num);
    }

    internal void calc_kNN(int k, double x, double y) {
      Punkt p = new Punkt(x, y);
      KNN kNN = new KNN(k, p, points, num_features);
      I_Schaubild.showkNN(x, y, kNN.getKNNList(), kNN.getFeatureCountList());
    }

    internal void deletePoint() {
      points.RemoveAt(activatePointNum);
      dieGUI.removeFromPointListBox(activatePointNum);
      activatePointNum = -1;
    }

    internal void activatePoint(int selectedIndex) {
      activatePointNum = selectedIndex;
    }

    internal void writePointsToFile(StreamWriter datei) {
      foreach (Punkt point in points) { 
        datei.WriteLine("[Point]");
        point.writeToFile(datei);
      }
    }

    internal string readPointFromFile(StreamReader datei) {
      ConfigLine line;
      Punkt.PointConf pointconf_attr = 0;
      string val, attr, linestr;
      bool convert_ok;
      double x = 0;
      double y = 0;
      int featurenum=0;
      bool isFeaturePoint = false;
      PointStyle style = PointStyle.Square;
      Color color = Color.Red;
      int size = 5;
      int dx;
      int dy;
      char name;
      do {
        linestr = datei.ReadLine();
        if (linestr.Length > 0 && linestr[0] != '[') {
          line = new ConfigLine(linestr);
          attr = line.getAttr();
          val = line.getVal();
          try {
            pointconf_attr = (Punkt.PointConf) Enum.Parse(typeof(Punkt.PointConf), attr);
            convert_ok = true;
          } catch (Exception) {
            convert_ok = false;
            // MsgBox?
          }
          if (convert_ok) {
            try {
              switch (pointconf_attr) {
                case Punkt.PointConf.x:              x = Convert.ToDouble(val);                                break;
                case Punkt.PointConf.y:              y = Convert.ToDouble(val);                                break;
                case Punkt.PointConf.isFeaturePoint: isFeaturePoint = Boolean.Parse(val);                      break;
                case Punkt.PointConf.featurenum:     featurenum = Convert.ToInt16(val);                        break;
                case Punkt.PointConf.size:           size = Convert.ToInt16(val);                              break;
                case Punkt.PointConf.style:          style = (PointStyle) Enum.Parse(typeof(PointStyle), val); break;
                case Punkt.PointConf.color:          color = dieGUI.String2Color(val);                         break;
                case Punkt.PointConf.dx:             dx = Convert.ToInt16(val);                                break;
                case Punkt.PointConf.dy:             dy = Convert.ToInt16(val);                                break;
                case Punkt.PointConf.name:           name = Convert.ToChar(val);                               break;
                default: val = "unknown option"; break;
              }
            } catch (Exception) {
              //MsgBox?
            }
          }
        }
      } while (!datei.EndOfStream && (linestr.Length == 0 || (linestr.Length > 0 && linestr[0] != '[')));
      if (isFeaturePoint) {
        this.addPoint(x, y, featurenum);
      } else 
        points.Last<Punkt>().setPointConfig(new PointConfig(color, size, style));
      return linestr;
    }

    internal void drawPointConfig(Graphics g, int start, int itemHeight, int width) {
      Bitmap bm;
      int y;
      for (int i = start; i < points.Count; i++) {
        bm = points[i].getPointBitmap();
        y = (i - start) * itemHeight + (11-bm.Height) / 2 + 4;
        g.DrawImage(bm, 5+(11-bm.Width)/2, y);
      }
    }

    internal void deleteLabelsFromPoints() {
      foreach (Punkt punkt in points) {
        punkt.setFeatureNum(-1);
      }
    }

  }
}
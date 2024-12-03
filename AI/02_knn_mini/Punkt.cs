using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knn {
  public class Punkt {
    private double x;
    private double y;
    private bool isLabelPoint;
    private PointConfig pointconf;
    protected Feature label;
    protected int featureNum;

    internal PointConfig Pointconf { get => pointconf;  }

    public enum PointConf {x, y, isFeaturePoint, featurenum, size, style, color, dx, dy, name}

    public Punkt(double x, double y, Feature label, int featureNum, Color color) {
      this.x = x;
      this.y = y;
      this.isLabelPoint = true;
      this.pointconf = new PointConfig(color);
      this.label = label;
      this.featureNum = featureNum;
    }

    public Punkt(double x, double y) {
      this.x=x;
      this.y=y;
      this.isLabelPoint=false;
    }

    public Punkt(double x, double y, int featureNum) {
      this.x = x;
      this.y = y;
      this.isLabelPoint = true;
      this.pointconf = new PointConfig(featureNum, PointStyle.Square);
      this.featureNum = featureNum;
    }


    public double getX() {
      return x;
    }

    public double getY() {
      return y;
    }

    public int getFeatureNum() {
      return isLabelPoint ? featureNum : -1;
    }

    internal void decLabelNum() {
      featureNum--;
    }

    public void drawPoint(PlotImage I_Schaubild, Graphics g) {
      int x_img = I_Schaubild.x_coord2img(x);
      int y_img = I_Schaubild.y_coord2img(y);
      Bitmap pointbm = this.getPointBitmap();
      g.DrawImage(pointbm, x_img - pointbm.Width / 2, y_img - pointbm.Height / 2);
    }

    internal void setPointConfig(PointConfig pointConfig) {
      this.pointconf = pointConfig;
    }

    public string getCoordString() {
      string ystr = Math.Round(y, 3) + " )";
      return "( " + Math.Round(x, 3) + " | " + ystr;
    }

    public bool IsLabelPoint() {
      return isLabelPoint;
    }

    public void setFunction(Feature f) {
      if (isLabelPoint) {
        this.label = f;
      }
    }

    internal void writeToFile(StreamWriter datei) {
      string val;
      foreach (PointConf conf in Enum.GetValues(typeof(PointConf))) {
        switch (conf) {
          case PointConf.x:           val = x.ToString();                        break;
          case PointConf.y:           val = y.ToString();                        break;
          case PointConf.isFeaturePoint: val = isLabelPoint.ToString();             break;
          case PointConf.featurenum:     val = featureNum.ToString();                 break;
          case PointConf.size:        val = pointconf.Size.ToString();           break;
          case PointConf.style:       val = pointconf.Style.ToString();          break;
          case PointConf.color:       val = pointconf.Color.ToArgb().ToString(); break;
          case PointConf.dx:          val = "0";                                 break;
          case PointConf.dy:          val = "0";                                 break;
          case PointConf.name:        val = "_";                                 break;
          default: val = "unknown point-option";                                 break;
        }
        datei.WriteLine(conf.ToString() + "=" + val);
      }
    }

    public Bitmap getPointBitmap() {
      return pointconf.getBitmap();
    }

    internal void setColor(Color color) {
      pointconf.setColor(color);
    }

    internal void setFeatureNum(int featureNum) {
      this.featureNum = featureNum;
      if (featureNum == -1) {
        this.setColor(Color.Black);
      }
    }

    internal void movePoint(double new_x, double new_y) {
      this.x = new_x;
      this.y = new_y;
    }

  }
}
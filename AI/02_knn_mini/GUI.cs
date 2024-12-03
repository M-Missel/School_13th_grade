using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace knn {
  public partial class GUI : Form {
    public static Color[] featureColors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Pink,
                                          Color.Orange, Color.Brown, Color.Magenta, Color.LightBlue };
    private enum FeatureConf {feature, isChecked, color, width };
    private enum LayoutConf {
      xmin, xmax, ymin, ymax,
      gridx, gridy, 
      joinxy
    }
    private Steuerung dieSteuerung;
    private List<TextBox> T_FeatureList;
    private ScrollWatchListBox LB_Points;
    private List<ComboBox> list_CB_FeatureAttach;
    private List<ButtonColor.ButtonColor> BC_LabelColList;
    private PlotImage I_Plot;
    private int feature_def_height = 25;

    public GUI() {
      InitializeComponent();
      I_Plot = new PlotImage(this, 205, M_Hauptmenu.Height);
      list_CB_FeatureAttach = new List<ComboBox>();
      list_CB_FeatureAttach.Add(CB_FeatureChoice);

      this.resetGUI();
      dieSteuerung.newFeature();
      dieSteuerung.checkArgs();
    }

    internal void changeCoord(double xmin, double xmax, double ymin, double ymax) {
      T_xmin.Text = xmin.ToString();
      T_xmax.Text = xmax.ToString();
      T_ymin.Text = ymin.ToString();
      T_ymax.Text = ymax.ToString();
    }

    private void resetGUI() {
      dieSteuerung = new Steuerung(this);
      GC.Collect(); 
      if (T_FeatureList != null) {
        T_FeatureList.Clear();
      }
      T_FeatureList = new List<TextBox>();
      if (BC_LabelColList != null) {
        BC_LabelColList.Clear();
      }
      BC_LabelColList = new List<ButtonColor.ButtonColor>();
      P_Features.Controls.Clear();
      if (LB_Points!=null) {
        TP_Punkt.Controls.Remove(LB_Points);
      }
      LB_Points = new ScrollWatchListBox(this);
      this.TP_Punkt.Controls.Add(this.LB_Points);
      this.LB_Points.FormattingEnabled = true;
      this.LB_Points.Location = new System.Drawing.Point(268, 6);
      this.LB_Points.Name = "LB_Points";
      this.LB_Points.Size = new System.Drawing.Size(133, 95);
      this.LB_Points.TabIndex = 123;
      this.LB_Points.Visible = false;
      this.LB_Points.SelectedIndexChanged += new System.EventHandler(this.LB_Points_SelectedIndexChanged);

      foreach (ComboBox cb in list_CB_FeatureAttach) {
        cb.Items.Clear();
        cb.Text = "";
      }
      dieSteuerung.makeImageAssoc(I_Plot);
      L_Feature.Text = "Feature:";
      T_xmin.Text = "-1";
      T_xmax.Text = "11";
      T_ymin.Text = "-1";
      T_GitX.Text = "1";
      T_GitY.Text = "1";
      CB_koppleY.Checked = true;
      T_ymax.Text = "11";
      T_PunktX.Text = "";
      T_PunktY.Text = "";
      LB_Points.Items.Clear();
      B_deletePoint.Visible = false;
      this.Refresh();
    }

    public void setTitle(string title) {
      this.Text = title;
    }

    private void B_newLabelClick(object sender, EventArgs e) {
      dieSteuerung.newFeature();
      this.B_drawFeature_Click(this, null);
    }

    public void simulateCB_koppleY_Click() {
      CB_koppleY_CheckedChanged(this, null);
    }

    public void newFeature(int newFeatureNum) {
      int diff_val;
      string diff_str;
      if (newFeatureNum >= 1) {
        L_Feature.Text = "Features:";
        B_zeichneFeatures.Text = "zeichne Features";
      }
      diff_val = newFeatureNum - 4;
      if (diff_val == 0) {
        diff_str = "";
      } else
        if (diff_val > 0) {
        diff_str = "+" + diff_val.ToString();
      } else {
        diff_str = diff_val.ToString();
      }

      T_FeatureList.Add(new TextBox());
      T_FeatureList[newFeatureNum].Parent = P_Features;
      T_FeatureList[newFeatureNum].Left = 40;
      T_FeatureList[newFeatureNum].Top = newFeatureNum * feature_def_height + 7;
      T_FeatureList[newFeatureNum].Text = $"C{newFeatureNum+1}";
      foreach (ComboBox cb in list_CB_FeatureAttach) {
        this.addFeatureToComboBox(cb, newFeatureNum);
      }
      T_FeatureList[newFeatureNum].TextChanged += T_LabelChange;
      T_LabelChange(T_FeatureList[newFeatureNum], null);  
      T_FeatureList[newFeatureNum].TabIndex = newFeatureNum * 4 + 2;

      BC_LabelColList.Add(new ButtonColor.ButtonColor());
      BC_LabelColList[newFeatureNum].Parent = P_Features;
      BC_LabelColList[newFeatureNum].Left = 138;
      BC_LabelColList[newFeatureNum].Top = newFeatureNum * feature_def_height + 3;
      BC_LabelColList[newFeatureNum].Color = getStandardColor(newFeatureNum);
      BC_LabelColList[newFeatureNum].TabIndex = newFeatureNum * 4 + 4;
    }

    private Color getStandardColor(int feature_num) {
      int index = feature_num % featureColors.Length;
      return featureColors[index];
    }

    private void addFeatureToComboBox(ComboBox combobox, int feature_num) {
      combobox.Items.Add(T_FeatureList[feature_num].Text);
      if (combobox.SelectedItem == null) {
        combobox.SelectedItem = combobox.Items[0];
      }
    }

    void T_LabelChange(object sender, EventArgs e) {
      int changedIndex = getChangedIndex((TextBox)sender);
      CB_FeatureChoice.Items[changedIndex] = T_FeatureList[changedIndex].Text;
    }

    private int getChangedIndex(TextBox changedTextbox) {
      for (int i = 0; i < T_FeatureList.Count; i++) {
        if (T_FeatureList[i] == changedTextbox) {
          return i;
        }
      }
      return -1;
    }

    private void setFeatureColor(int feature_num, Color color) {
      BC_LabelColList[feature_num].Color = color;
    }

    private void setFeatureStr(int feature_num, string str) {
      T_FeatureList[feature_num].Text = str;
    }

    public void setcoordSize() {
      double xmin = Convert.ToDouble(T_xmin.Text);
      double xmax = Convert.ToDouble(T_xmax.Text);
      double ymin = Convert.ToDouble(T_ymin.Text);
      double ymax = Convert.ToDouble(T_ymax.Text);
      I_Plot.setXYDim(xmin, xmax, ymin, ymax);
    }

    public void drawCoordsAndGrid(Graphics g) {
      double x_gitter = Convert.ToDouble(T_GitX.Text);
      double y_gitter = Convert.ToDouble(T_GitY.Text);
      I_Plot.drawGrid(x_gitter, y_gitter, g);
      I_Plot.drawCoords(x_gitter, y_gitter, g);
    }

    public string getFeatureName(int feature_num) {
      return T_FeatureList[feature_num].Text;
    }

    public Color getFeatureColor(int featureNum) {
      if (featureNum != -1) {
        return  BC_LabelColList[featureNum].Color;
      } else {
        return Color.Black;
      }
    }

    private void B_drawFeature_Click(object sender, EventArgs e) {
      I_Plot.draw();
    }

    private void CB_koppleY_CheckedChanged(object sender, EventArgs e) {
      if (CB_koppleY.Checked) {
        T_GitY.Enabled = false;
        T_ymax.Enabled = false;
        this.T_GitX_TextChanged(T_GitX, null);
        this.setYMax(T_GitY, null);
      } else {
        T_GitY.Enabled = true;
        T_ymax.Enabled = true;
      }
    }

    private void T_GitX_TextChanged(object sender, EventArgs e) {
      double result;
      TextBox_TextChanged(sender, null);
      CB_koppleY.Enabled = !T_GitX.Text.Contains("pi");
      if (CB_koppleY.Checked) {
        if (!T_GitX.Text.Contains("pi")) {   // eigentlich unnötig
          if (Double.TryParse(T_GitX.Text, out result)) {
            T_GitY.Text = T_GitX.Text;
          }
        } else {
          CB_koppleY.Checked = false;
        }
      }
    }

    private void setYMax(object sender, EventArgs e) {
      TextBox_TextChanged(sender, null);
      if (CB_koppleY.Checked) {
        try {
          double xmin = Convert.ToDouble(T_xmin.Text);
          double xmax = Convert.ToDouble(T_xmax.Text);
          double ymin = Convert.ToDouble(T_ymin.Text);
          double x_per_pixel = (xmax - xmin) / (I_Plot.Width - 10);
          double ymax = ymin + (I_Plot.Height - 10) * x_per_pixel;
          T_ymax.Text = ymax.ToString();
        } catch (Exception) { }
      }
    }

    private void B_berechnePunktY_Click(object sender, EventArgs e) {
      double x = Convert.ToDouble(T_PunktX.Text);
      double y = Convert.ToDouble(T_PunktY.Text);
      int func_num = CB_FeatureChoice.SelectedIndex;
      dieSteuerung.addPoint(x, y, func_num);
      I_Plot.draw();
    }

    public void setError(TextBox textBox, bool error) {
      if (error) {
        textBox.BackColor = Color.Orange;
      } else {
        textBox.BackColor = Color.White;
      }
    }

    private void GUI_Resize(object sender, EventArgs e) {
      if (this.WindowState != FormWindowState.Minimized) {
        if (this.Height <= 400) { this.Height = 400; }
        if (this.Width <= 825)  { this.Width = 825; }
      }
      TC_Config.Top     = this.ClientSize.Height - TC_Config.Height-5;
      P_Description.Top = this.ClientSize.Height - TC_Config.Height-5;
      this.simulateCB_koppleY_Click();
      I_Plot.draw();
    }

    private void MI_DateiOeffnen_Click(object sender, EventArgs e) {
      DialogResult res = FD_Open.ShowDialog();
      if (res == DialogResult.OK) {
        string filename = FD_Open.FileName;
        this.loadFile(filename);
      }
    }

    private void MI_DateiSpeichernUnter_Click(object sender, EventArgs e) {
      DialogResult res = FD_Save.ShowDialog();
      if (res == DialogResult.OK) {
        string filename = FD_Save.FileName;
        this.saveFile(filename);
        dieSteuerung.Filename = filename;
      }
    }

    private void saveFile(string filename) {
      string val;
      StreamWriter datei = new StreamWriter(filename);
      for (int feature_num = 0; feature_num < dieSteuerung.getFeatureNum(); feature_num++) {
        datei.WriteLine("[Feature]");
        foreach (FeatureConf conf in Enum.GetValues(typeof(FeatureConf))) {
          switch (conf) {
            case FeatureConf.feature:   val = this.getFeatureName(feature_num); break;
            case FeatureConf.isChecked: val = "true"; break;
            case FeatureConf.color:     val = this.getFeatureColor(feature_num).ToArgb().ToString(); break;
            case FeatureConf.width:     val = "1"; break;
            default: val = "unknown option"; break;
          }
          datei.WriteLine(conf.ToString() + "=" + val);
        }
      }

      datei.WriteLine("[Layout]");
      foreach (LayoutConf conf in Enum.GetValues(typeof(LayoutConf))) {
        switch (conf) {
          case LayoutConf.xmin:      val = this.T_xmin.Text; break;
          case LayoutConf.xmax:      val = this.T_xmax.Text; break;
          case LayoutConf.ymin:      val = this.T_ymin.Text; break;
          case LayoutConf.ymax:      val = this.T_ymax.Text; break;
          case LayoutConf.gridx:     val = this.T_GitX.Text; break;
          case LayoutConf.gridy:     val = this.T_GitY.Text; break;
          case LayoutConf.joinxy:    val = this.CB_koppleY.Checked.ToString(); break;
          default: val = "unknown value"; break;
        }
        datei.WriteLine(conf.ToString() + "=" + val);
      }
      dieSteuerung.writePointsToFile(datei);
      datei.Close();
      MessageBox.Show("Datei gespeichert unter " + filename);
    }

    public Color String2Color(string val) {
      Color color;
      try {
        color = Color.FromArgb(Convert.ToInt32(val));
      } catch (Exception) {
        color = Color.Black;
        MessageBox.Show("Fehler: Der Wert '" + val + "' stellt keine Farbe dar.\n" +
                        "Stattdessen wird Schwarz verwendet.");
      }
      return color;
    }

    public void loadFile(string filename) {
      FeatureConf conf_attr;
      LayoutConf layoutconf_attr;
      string linestr, val, attr;
      ConfigLine line;
      bool convert_ok;

      this.resetGUI();
      StreamReader datei = new StreamReader(filename);
      int feature_num = 0;
      while (!datei.EndOfStream) {
        linestr = datei.ReadLine();
        if (linestr == "[Feature]") {
          dieSteuerung.newFeature();                   
          foreach (FeatureConf conf in Enum.GetValues(typeof(FeatureConf))) {
            linestr = datei.ReadLine();
            line = new ConfigLine(linestr);
            attr = line.getAttr();
            val = line.getVal();
            try {
              conf_attr = (FeatureConf)Enum.Parse(typeof(FeatureConf), attr);
              convert_ok = true;
            } catch (Exception) {
              convert_ok = false;
              conf_attr = 0;
              MessageBox.Show("Fehler beim Lesen der Datei:\n" +
                              "Unbekannte Option: " + attr + "\n" +
                              "Wert wird ignoriert.");
            }
            if (convert_ok) {
              try {
                switch (conf_attr) {
                  case FeatureConf.feature:   this.setFeatureStr(feature_num, val); break;
                  case FeatureConf.color:     this.setFeatureColor(feature_num, String2Color(val)); break;
                  default: val = "unknown option"; break;
                }
              } catch (Exception) {
                MessageBox.Show("Fehler beim Lesen der Datei:\n" +
                                "Unbekannter Attributwert für Option '" + attr + "':\n" +
                                "Wert: " + val + "\n" +
                                "Wert wird ignoriert.");
              }
            }
          }
          dieSteuerung.updatePoints(); // muss sofort erzeugt werden für den Fall, dass in der Datei ein Bezug auf ein Feature vorhanden ist
          feature_num++;
        }
        if (linestr == "[Layout]") {
          foreach (LayoutConf conf in Enum.GetValues(typeof(LayoutConf))) {
            linestr = datei.ReadLine();
            if (linestr != null) {
              line = new ConfigLine(linestr);
              val = line.getVal();
              attr = line.getAttr();
              try {
                convert_ok = true;
                layoutconf_attr = (LayoutConf)Enum.Parse(typeof(LayoutConf), attr);
              } catch (Exception) {
                convert_ok = false;
                layoutconf_attr = 0;
                MessageBox.Show("Fehler beim Lesen der Datei:\n" +
                                "Unbekannte Option: " + attr + "\n" +
                                "Wert wird ignoriert.");
              }
            } else {
              convert_ok = false;
              layoutconf_attr = 0;
              val = null;
              attr = null;
            }
            if (convert_ok) {
              try {
                switch (layoutconf_attr) {
                  case LayoutConf.xmin:      this.T_xmin.Text = val; break;
                  case LayoutConf.xmax:      this.T_xmax.Text = val; break;
                  case LayoutConf.ymin:      this.T_ymin.Text = val; break;
                  case LayoutConf.ymax:      this.T_ymax.Text = val; break;
                  case LayoutConf.gridx:     this.T_GitX.Text = val; break;
                  case LayoutConf.gridy:     this.T_GitY.Text = val; break;
                  case LayoutConf.joinxy:    this.CB_koppleY.Checked = Boolean.Parse(val); break;
                  default: break;
                }
              } catch (Exception) {
                MessageBox.Show("Fehler beim Lesen der Datei:\n" +
                                "Unbekannter Attributwert für Option '" + attr + "':\n" +
                                "Wert: " + val + "\n" +
                                "Wert wird ignoriert.");
              }
            }
          }
        }
        while (linestr == "[Point]") {
          linestr = dieSteuerung.readPointFromFile(datei); // in Steuerung wird schon die nächste Zeile gelesen
        }
      }
      datei.Close();
      dieSteuerung.Filename = filename;
      this.B_drawFeature_Click(this, null);
    }

    public void drawImage(Graphics g) {
      dieSteuerung.drawAll(g);
    }

    private void MI_DateiSpeichern_Click(object sender, EventArgs e) {
      if (dieSteuerung.Filename == "") {
        MI_DateiSpeichernUnter_Click(this, null);
      } else {
        this.saveFile(dieSteuerung.Filename);
      }
    }

    private void MI_DateiBeenden_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void MI_BearbeitenKopieren_Click(object sender, EventArgs e) {
      Rectangle newrect = new Rectangle(0, 0, I_Plot.Width - 10 + 1, I_Plot.Height - 10 + 1);
      PictureBox pb = new PictureBox();
      pb.Width = I_Plot.Width - 10 + 1;
      pb.Height = I_Plot.Height - 10 + 1;
      pb.Paint += pb_Paint;

      Bitmap bm = new Bitmap(I_Plot.Width - 10 + 1, I_Plot.Height - 10 + 1);
      pb.DrawToBitmap(bm, newrect);
      Clipboard.SetImage(bm);
      double width = I_Plot.getXMax() - I_Plot.getXMin();
      MessageBox.Show("Kopieren in Zwischenablage erledigt.\n" +
                      "\n" +
                      "In Zielanwendung mit Strg-V einfügen und\n" +
                      "Größe auf " + width.ToString() + " cm ändern.");
    }

    void pb_Paint(object sender, PaintEventArgs e) {
      Bitmap bm = new Bitmap(I_Plot.Width, I_Plot.Height);
      I_Plot.DrawToBitmap(bm, I_Plot.ClientRectangle);
      Rectangle newrect = new Rectangle(0, 0, I_Plot.Width - 10 + 1, I_Plot.Height - 10 + 1);
      e.Graphics.DrawImage(bm, newrect, new Rectangle(5, 5, I_Plot.Width - 10 + 1, I_Plot.Height - 10 + 1), GraphicsUnit.Pixel);
    }

    private void MI_DateiNeu_Click(object sender, EventArgs e) {
      this.resetGUI();
      dieSteuerung.newFeature();
    }

    private void TextBox_TextChanged(object sender, EventArgs e) {
      setError((TextBox)sender, false);
    }

    private void MI_Punkte_Click(object sender, EventArgs e) {
      if (MI_Punkte.Text == "&Punktemodus aktivieren") {
        MI_Punkte.Text = "&Punktemodus ausschalten";
        MI_kNN.Text = "&kNN-Modus aktivieren";
      } else {
        MI_Punkte.Text = "&Punktemodus aktivieren";
        MI_kNN.Text = "&kNN-Modus ausschalten";
      }
      dieSteuerung.changekNNMode();
    }

    private void MI_knn_Click(object sender, EventArgs e) {
      if (MI_kNN.Text == "&kNN-Modus aktivieren") {
        MI_kNN.Text = "&kNN-Modus ausschalten";
        MI_Punkte.Text = "&Punktemodus aktivieren";
      } else {
        MI_kNN.Text = "&kNN-Modus aktivieren";
        MI_Punkte.Text = "&Punktemodus ausschalten";
      }
      dieSteuerung.changekNNMode();
    }

    private void addFeatureAttachListBox(ListBox listbox, string xstr) {
      listbox.Items.Add(xstr);
      listbox.Visible = true;
    }

    internal void clickRight(int x, int y, bool hasDistance) {
      if (dieSteuerung.getkNNMode() == Mode.POINT) {
        if (hasDistance) {
          dieSteuerung.addPointByClick(I_Plot.x_img2coord(x), I_Plot.y_img2coord(y), CB_FeatureChoice.SelectedIndex);
        }
      } else {
        int k = TB_kNN_k.Value;
        dieSteuerung.calc_kNN(k, I_Plot.x_img2coord(x), I_Plot.y_img2coord(y));
      }
    }

    internal void addPointListbox(string pointcoords) {
      addFeatureAttachListBox(LB_Points, pointcoords);
    }

    internal void removeFromPointListBox(int pnum) {
      LB_Points.Items.RemoveAt(pnum);
      B_deletePoint.Visible = false;
      if (LB_Points.Items.Count == 0) {
        LB_Points.Visible = false;
      }
    }

    private void B_deletePoint_Click(object sender, EventArgs e) {
      dieSteuerung.deletePoint();
      B_drawFeature_Click(this, null);
    }

    private void LB_Points_SelectedIndexChanged(object sender, EventArgs e) {
      if (LB_Points.SelectedIndex > -1) {
        dieSteuerung.activatePoint(LB_Points.SelectedIndex);
        B_deletePoint.Visible = true;
      }
    }

    private void changeFuncAttachListBox(ListBox listbox, int activeNum, string v) {
      listbox.Items[activeNum] = v;
    }

    internal void changePointListBox(int activatePointNum, string v) {
      changeFuncAttachListBox(LB_Points, activatePointNum, v);
    }

    private void P_PointStyle_Paint(object sender, PaintEventArgs e) {
      dieSteuerung.drawPointConfig(e.Graphics, LB_Points.TopIndex, LB_Points.ItemHeight, P_PointStyle.Width);
    }

    public void updatePanel() {
      P_PointStyle.Refresh();
    }

    private void TB_kNN_k_ValueChanged(object sender, EventArgs e) {
      L_kNN_k.Text = "k=" + TB_kNN_k.Value;
    }

    internal void showkNN(double x, double y, List<PointDistance> kNNList, List<FeatureCount> featureCountList) {
      T_kNN_x.Text = x.ToString();
      T_kNN_y.Text = y.ToString();
      LB_knnList.Items.Clear();
      foreach (PointDistance pd in kNNList) {
        Punkt p = pd.getPoint();
        LB_knnList.Items.Add($"{p.getFeatureNum()}: {p.getCoordString()}");
      }
      LB_kNN_Counts.Items.Clear();
      foreach(FeatureCount fc in featureCountList) {
        LB_kNN_Counts.Items.Add($"{fc.getFeatureNum()}: {fc.getCount()}");
      }                
    }

    internal void showMode(Mode currentMode) {
      switch (currentMode) {
        case Mode.POINT: L_DescriptionHeader.Text = "Punktemodus";
                         L_Description.Text = "Rechts klicken (und gedrückt halten): Punkte zeichnen\n" +
                                              "Feature-Auswahl: in Registerkarte auswählen\n\n" +
                                              "Strg-K: In kNN-Modus wechseln";
                         TC_Config.SelectedTab = TP_Punkt;
                         break;
        case Mode.KNN:   L_DescriptionHeader.Text = "kNN-Modus";
                         L_Description.Text = "Rechts klicken (und gedrückt halten): kNN berechnen und animieren\n\n" +
                                              "Strg-K: In Punkte-Modus wechseln";
                         TC_Config.SelectedTab = TP_kNN;
                         break;
        default:         throw new NotImplementedException();
      }
    }

    private void B_Zufallspunkte_Click(object sender, EventArgs e) {
      Random random = new Random();
      double xmin = I_Plot.getXMin();
      double xmax = I_Plot.getXMax();
      double ymin = I_Plot.getYMin(); 
      double ymax = I_Plot.getYMax();
      for (int i = 0; i < 20; i++) {
        double x = random.NextDouble()*(xmax - xmin) + xmin;
        double y = random.NextDouble()*(ymax - ymin) + ymin;
        int featurenum = random.Next(dieSteuerung.getFeatureNum());
        dieSteuerung.addPointByClick(x, y, featurenum);
      }
    }
  }
}
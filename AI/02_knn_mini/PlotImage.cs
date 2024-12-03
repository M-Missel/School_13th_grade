using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Permissions;

namespace knn {
  public class PlotImage: PictureBox  {
    private double xmin;
    private double xmax;
    private double ymin;
    private double ymax;
    private GUI dieGUI;
    private Pen stift;
    private Font coordFont;
    private int lastClicked_x;
    private int lastClicked_y;

    public PlotImage(GUI pGUI, int left, int top) {
      this.InitializeComponent();
      this.Left = left;
      this.Top = top;
      this.Parent = pGUI;
      dieGUI = pGUI;
      coordFont = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // was: DefaultFont;
      this.BackColor = Color.White;
      this.setImageSize();
      reset_lastClickedPos();
    }

    private void reset_lastClickedPos() {
      lastClicked_x = -20; // ein negativer Wert, damit der erste Klick auf jeden Fall
      lastClicked_y = -20; // registriert wird (dann ist die Differenz mindestens 20
    }

    private void InitializeComponent() {
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // ImageFunc
      // 
      this.Paint      += new System.Windows.Forms.PaintEventHandler(this.PlotImage_Paint);
      this.MouseDown  += new System.Windows.Forms.MouseEventHandler(this.ImageFunc_MouseDown);
      this.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.FuncWin_MouseMove);
      this.MouseUp    += new System.Windows.Forms.MouseEventHandler(this.ImageFunc_MouseUp);
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);
    }

    private void ImageFunc_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Right) {
        manageButtonRightClick(e.X, e.Y);
      }
    }

    private void ImageFunc_MouseUp(object sender, MouseEventArgs e) {
      reset_lastClickedPos();
    }

    private void FuncWin_MouseMove(object sender, MouseEventArgs e) {
      this.Refresh(); 
      if (e.Button == MouseButtons.Right) {
        manageButtonRightClick(e.X, e.Y);
      }
    }

    private void manageButtonRightClick(int x, int y) {
      bool hasDistance = ((Math.Abs(x - lastClicked_x) >= 10)
                       || (Math.Abs(y - lastClicked_y) >= 10));
      if (hasDistance) {
        lastClicked_x = x;
        lastClicked_y = y;
      }
      dieGUI.clickRight(x, y, hasDistance);
    }

    void PlotImage_Paint(object sender, PaintEventArgs e) {
      dieGUI.drawImage(e.Graphics);
    }

    public Int32 x_coord2img(double x) {
      return Convert.ToInt32((x-xmin)*(this.Width-10)/(xmax-xmin))+5;
    }

    public Int32 y_coord2img(double y) {
      Int32 y_img;
      try {
        y_img = Convert.ToInt32(this.Height - 10 - (y - ymin) * (this.Height - 10) / (ymax - ymin)) + 5; 
      } catch (Exception) {
        y_img = (y>ymax)?-10:this.Height+10;
      }
      return y_img;
    }

    public double x_img2coord(Int32 x_img) {
      return (x_img-5)*(xmax - xmin) / (this.Width - 10) + xmin;
    }

    public double y_img2coord(Int32 y_img) {
      //return -(y_img - 5) * (ymax - ymin) / (this.Height - 10) + 1 + ymin;
      return -(y_img - this.Height + 5) * (ymax - ymin) / (this.Height - 10) + ymin;
    }

    public void setXYDim(double xmin, double xmax, double ymin, double ymax) {
      this.xmin = xmin;
      this.xmax = xmax;
      this.ymin = ymin;
      this.ymax = ymax;
    }

    public double getXMin() {
      return this.xmin;
    }

    public double getXMax() {
      return this.xmax;
    }

    public double getYMin() {
      return this.ymin;
    }

    public double getYMax() {
      return this.ymax;
    }

    private void drawLine(double x1, double y1, double x2, double y2, Graphics g) {
      Int32 x1_img = this.x_coord2img(x1);
      Int32 y1_img = this.y_coord2img(y1);
      Int32 x2_img = this.x_coord2img(x2);
      Int32 y2_img = this.y_coord2img(y2);
      try {
        g.DrawLine(stift, x1_img, y1_img, x2_img, y2_img);
      } catch (Exception) {
        // Exception falls y1_img oder y2_img < als -1.073.741.760 wird
      }
    }

    public void drawCoords(double xgrid, double ygrid, Graphics g) {
      double x;
      double y;
      ygrid = Math.Abs(ygrid);
      int x_img, y_img;
      Rectangle textrect;
      int x0_img = this.x_coord2img(0);
      if (x0_img < 50) {
        x0_img = 50;
      }
      int y0_img = this.y_coord2img(0);
      if (y0_img > this.Height-50) {
        y0_img = this.Height-50;
      }
      Color penColor = Color.Black;
      stift = new Pen(penColor, 1);
      stift.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
      //     this.drawLine(this.getXMin(), 0, this.getXMax(), 0, g);              // x-Achse
      g.DrawLine(stift, 0, y0_img, this.Width-5, y0_img);
      g.DrawLine(stift, Width - 10, y0_img + 5, Width - 5, y0_img);
      g.DrawLine(stift, Width - 5, y0_img, Width - 10, y0_img - 5);

      // Achsenskalen
      penColor = Color.Black;
      int deltax_img = x_coord2img(2*xgrid) - x_coord2img(xgrid); // deltax_img berechnet den Pixelabstand zwischen zwei x-Strichen
      while (deltax_img <= 1) {
        xgrid = xgrid*10;
        deltax_img = x_coord2img(xgrid) - x_coord2img(xgrid);
      }
                                           // die Breite einer (beliebigen) x-Achsen-Beschriftung
      double xgridminval = xgrid;
      int fac = -1;
      while (xgridminval > xmin) {
        fac--;
        xgridminval = xgrid*fac;
      }
      xgridminval = xgrid*fac;
      int textwidth = Convert.ToInt16(Math.Max(1, // g.MeasureString(xmin.ToString(), coordFont).Width, // Wofür war dieser Fall da?
                                               g.MeasureString(xgridminval.ToString(), coordFont).Width));
      int mainx = (textwidth / deltax_img) + 1; // Quotient gibt an, bei wie vielen
                                // Strichen der x-Wert ohne Textüberschneidung geschrieben werden
                                // soll: Bsp: Textbreite = 70
                                //            deltax_img = 40 (Abstand sind also 40 Pixel)
                                //            ==> Nur jeder 2. Strich wird beschriftet
      Brush schriftfarbe = new SolidBrush(penColor);
      StringFormat sf = new StringFormat();
      sf.Alignment = StringAlignment.Center;
      sf.LineAlignment = StringAlignment.Center;
      for (int i = Convert.ToInt16(xmin / xgrid) + 1; i < Convert.ToInt16(xmax / xgrid); i++) {
        x = xgrid*i;
        x_img = x_coord2img(x);
        g.DrawLine(stift,x_img, y0_img + 3, x_img, y0_img);
        if (i%mainx == 0 && x!=0) {
          g.DrawLine(stift, x_img, y0_img + 5, x_img, y0_img);
          textwidth = Convert.ToInt16(g.MeasureString(x.ToString(), coordFont).Width);
          textrect = new Rectangle(x_img - textwidth/2-1, y0_img+10, textwidth+2, Convert.ToInt16(g.MeasureString("0",coordFont).Height));
          g.DrawString(x.ToString(), coordFont, schriftfarbe, textrect,sf);
        }
      }
      StringFormat alignRight = new StringFormat();
      alignRight.Alignment = StringAlignment.Far;
      alignRight.LineAlignment = StringAlignment.Far;
      g.DrawString("x", coordFont, schriftfarbe, this.Width - 5, y0_img - 5, alignRight);

      // y-Achse 

      penColor = Color.Black;
      stift.Color = penColor;
      schriftfarbe = new SolidBrush(penColor);
      g.DrawLine(stift, x0_img, 5, x0_img, this.Height);             // y-Achse
      g.DrawLine(stift, x0_img - 5, 10, x0_img, 5);
      g.DrawLine(stift, x0_img, 5, x0_img + 5, 10);
      int deltay_img= y_coord2img(ygrid) - y_coord2img(2*ygrid);                // deltay_img berechnet den Pixelabstand zwischen zwei y-Strichen;
      while (deltay_img <= 1) {
        ygrid = ygrid * 10;
        deltay_img = y_coord2img(ygrid) - y_coord2img(2*ygrid);
      } 
      int textheight = Convert.ToInt16(g.MeasureString(ygrid.ToString(),coordFont).Height);
                                             // die Höhe einer (beliebigen) y-Achsen-Beschriftung
      int mainy = textheight / deltay_img + 1; // Quotient gibt an, bei wie vielen
                        // Strichen der y-Wert ohne Textüberschneidung geschrieben werden
                        // soll: Bsp: Texthöhe   = 70
                        //            deltay_img = 40 (Abstand sind also 40 Pixel)
                        //            ==> Nur jeder 2. Strich wird beschriftet
      for (int i=Convert.ToInt16(ymin/ygrid)+1;i<Convert.ToInt16(ymax/ygrid);i++) {
        y = i*ygrid;
        y_img = y_coord2img(y);
        g.DrawLine(stift, x0_img-3, y_img, x0_img, y_img);
        if (i%mainy == 0 && y!=0 && (y_img<y0_img || y0_img+25<y_img)) {
          g.DrawLine(stift, x0_img - 5, y_img, x0_img, y_img);
          textwidth = Convert.ToInt16(g.MeasureString(y.ToString(), coordFont).Width);
          g.DrawString(y.ToString(), coordFont, schriftfarbe, x0_img - textwidth - 10, y_img-textheight/2);
        }
      }
      g.DrawString("y", coordFont, schriftfarbe, x0_img + 10, 5);
    }

    public void drawGrid(double xgrid, double ygrid, Graphics g) {
      double x;
      double y;
      ygrid = Math.Abs(ygrid);
      Color penColor = Color.LightGray;
      stift = new Pen(penColor, 1);
      stift.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
      for (int i = Convert.ToInt32(xmin / xgrid); i <= Convert.ToInt32(xmax / xgrid); i++) {
        x = xgrid*i;
        this.drawLine(x, this.ymin, x, this.ymax,g);
      }
      for (int i = Convert.ToInt32(ymin / ygrid); i <= Convert.ToInt32(ymax / ygrid);i++) {
        y = i * ygrid;
        this.drawLine(this.xmin, y, this.xmax, y,g);
      }
    }

    public void setImageSize() {
      this.Width =  Parent.ClientSize.Width - 205;
      this.Height = Parent.ClientSize.Height - 205;
    }

    public void draw() {
      this.setImageSize();
      this.Refresh();
    }

    internal void showkNN(double x, double y, List<PointDistance> kNNList, List<FeatureCount> featureCountList) {
      Graphics g = CreateGraphics();
      Color colorOfNN = dieGUI.getFeatureColor(featureCountList[0].getFeatureNum());
      foreach (PointDistance pD in kNNList) {
        Punkt p = pD.getPoint();
        Color color = dieGUI.getFeatureColor(p.getFeatureNum());
        Pen pen = new Pen(color);
        stift = pen;
        drawLine(x, y, p.getX(), p.getY(), g);
      }
      double distance = Math.Sqrt(kNNList.Last<PointDistance>().getDistance());
      // double
      double xA = x - distance;
      double yA = y + distance;
      double xB = x + distance;
      double yB = y - distance;

      Brush brush = new SolidBrush(Color.FromArgb(20, colorOfNN.R, colorOfNN.G, colorOfNN.B));
      g.FillEllipse(brush,x_coord2img(xA), y_coord2img(yA), x_coord2img(xB)-x_coord2img(xA), y_coord2img(yB)-y_coord2img(yA));
      dieGUI.showkNN(x, y, kNNList, featureCountList);
    }
  }
}
using System;
using System.Drawing;
namespace knn {
  public enum PointStyle { Cross, Square, Circle };
  internal class PointConfig {

    private PointStyle style;
    private Color color;
    private int size;
    private int featureNum;

    public int Size { get => size; }
    public Color Color { get => color;  }
    public PointStyle Style { get => style; }

    public PointConfig() {
      this.style = PointStyle.Circle;
      this.color = Color.Red;
      this.size = 11;
    }

    public PointConfig(Color color, int size, PointStyle style) {
      this.color = color;
      this.size = size;
      this.style = style;
    }

    public PointConfig(Color color) {
      this.color=color;
      this.style = PointStyle.Circle;
      this.size = 11;
    }

    public PointConfig(int featureNum, PointStyle style) {
      this.featureNum=featureNum;
      this.style=style;
      this.color = GUI.featureColors[featureNum];
      this.size = 15;
    }

    public Bitmap getBitmap() {
      Bitmap bm = new Bitmap(size, size);
      Graphics g = Graphics.FromImage(bm);
      Pen pen = new Pen(color);
      Brush brush = new SolidBrush(color);
      switch (style) {
        case PointStyle.Cross:
          g.DrawLine(pen, 0, 0, size-1, size-1);
          g.DrawLine(pen, 0, size-1, size-1, 0);
          break;
        case PointStyle.Square:
          g.FillRectangle(brush, 0, 0, size-1, size-1);
          break;
        case PointStyle.Circle:
          g.FillEllipse(brush, 0, 0, size-1, size-1);
          break;
      }
      return bm;
    }

    internal void setColor(Color color) {
      this.color = color;
    }
  }
}
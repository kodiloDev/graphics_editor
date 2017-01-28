using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class Figura
    {
        public  int thickness;
        public  string name;
        public  SolidBrush color = new SolidBrush(Color.Black);
        public Figura(int thickness, string name, SolidBrush color)
        {
            this.thickness = thickness;
            this.name = name;
            this.color = color;
        }


        public virtual void Drawing(ref Graphics graphics, ref Graphics graphicsVisual, ref MouseEventArgs e)
        {
            graphics.FillEllipse(color, e.X, e.Y, thickness, thickness);
            graphicsVisual.FillEllipse(color, e.X, e.Y, thickness, thickness);
          //  graphics.Dispose();
          //  graphicsVisual.Dispose();
        }

      
    }
    class Draw : Figura
    {
        public Draw(int thickness, string name, SolidBrush color) : base(thickness, name, color)
        {

        }

       
    }
    class Line : Figura
    {
        int x, y;
        public Line(int thickness, string name, SolidBrush color, int x, int y) : base(thickness, name, color)
        {
            this.x = x;
            this.y = y;

        }

        public override void Drawing(ref Graphics graphics, ref Graphics graphicsVisual, ref MouseEventArgs e)
        {
            Pen pen = new Pen(color, thickness);
            graphics.SmoothingMode = SmoothingMode.AntiAlias; //сглаживание линии
            graphics.DrawLine(pen, x, y, e.X, e.Y);
            graphicsVisual.DrawLine(pen, x, y, e.X, e.Y);
           // graphics.Dispose();
           // graphicsVisual.Dispose();
        }
    }
    class RectangleClass : Figura
    {
        int x, y;
        public RectangleClass(int thickness, string name, SolidBrush color, int x, int y) : base(thickness, name, color)
        {
            this.x = x;
            this.y = y;
        }

        public override void Drawing(ref Graphics graphics, ref Graphics graphicsVisual, ref MouseEventArgs e)
        {
            Pen pen = new Pen(color, thickness);
            Rectangle rec = new Rectangle(Math.Min(e.X, x), Math.Min(e.Y, y), Math.Abs(e.X - x), Math.Abs(e.Y - y));
            graphics.DrawRectangle(pen, rec);
            graphicsVisual.DrawRectangle(pen, rec);
            //graphics.Dispose();
           // graphicsVisual.Dispose();

        }
    }

    class Circle : Figura
    {
        int x, y;
        public Circle(int thickness, string name, SolidBrush color, int x, int y) : base(thickness, name, color)
        {
            this.x = x;
            this.y = y;
        }

        public override void Drawing(ref Graphics graphics, ref Graphics graphicsVisual, ref MouseEventArgs e)
        {
            Pen pen = new Pen(color, thickness);
            int size = (e.X > e.Y) ? Math.Abs(e.X - x) : Math.Abs(e.Y - y);
            Rectangle rec = new Rectangle(Math.Min(e.X, x), Math.Min(e.Y, y), size, size);

          


            graphics.DrawEllipse(pen, rec);
            //graphics.Dispose();

            graphicsVisual.DrawEllipse(pen, rec);
            //graphicsVisual.Dispose();
        }
    }

   
}

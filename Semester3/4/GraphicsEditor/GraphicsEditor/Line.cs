using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GraphicsEditor
{
    class Line : Shape
    {
        private Pen pen = new Pen(Color.Black);
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        private bool selected;

        public Line() 
        {
            this.selected = false;
        }

        public Line(Point firstCoord, Point secondCoord)
        {
            this.Point1 = firstCoord;
            this.Point2 = secondCoord;
            this.selected = false;
        }

        public void SetSelected(bool selected)
        {
            this.selected = selected;
        }

        public void MouseDown(Point firstCoord)
        {
            this.Point1 = firstCoord;
        }

        public void MouseMove(Point secondCoord)
        {
            this.Point2 = secondCoord;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, Point1, Point2);
            if (selected)
            {
                DrawSelection(e);
            }
        }

        private void DrawSelection(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, new Rectangle(Point1.X - 2, Point1.Y - 2, 4, 4));
            e.Graphics.DrawEllipse(pen, new Rectangle(Point2.X - 2, Point2.Y - 2, 4, 4));
        }

        public bool Contain(MouseEventArgs e, TextBox tb)
        {
            Debug.Indent();
            Debug.WriteLine("in contain");
            if (MinDist(new Point(e.X, e.Y), tb) <= 15)
            {
                Debug.WriteLine("in first if");
                this.selected = true;
                return true;
            }
            return false;
        }

        private double MinDist(Point point, TextBox tb)
        {
            Point vector1 = new Point(point.X - Point1.X, point.Y - Point1.Y);
            Point vector2 = new Point(Point2.X - Point1.X, Point2.Y - Point1.Y);
            if (ScalarProduct(vector1, vector2) < 0.0)
            {
                return Math.Sqrt(ScalarProduct(vector1, vector1));
            }
            else
            {
                Point vector3 = new Point(point.X - Point2.X, point.Y - Point2.Y);
                Point vector4 = new Point(-vector2.X, -vector2.Y);
                if (ScalarProduct(vector3, vector4) < 0.0)
                {
                    return Math.Sqrt(ScalarProduct(vector3, vector3));
                }
                else
                {
                    double cosAlpha = ScalarProduct(vector3, vector4) / (Math.Sqrt(ScalarProduct(vector3, vector3)) * Math.Sqrt(ScalarProduct(vector4, vector4)));
                    double sinAlpha = Math.Sqrt(1 - cosAlpha * cosAlpha);
                    tb.Text = cosAlpha.ToString() ;
                    return sinAlpha * Math.Sqrt(ScalarProduct(vector3, vector3));
                }
            }
        }

        private double ScalarProduct(Point vector1, Point vector2)
        {
            return vector1.X * vector2.X + vector1.Y * vector2.Y;
        }
    }
}

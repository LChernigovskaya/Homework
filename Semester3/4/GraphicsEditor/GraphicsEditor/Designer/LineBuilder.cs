using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class LineBuilder : ShapeBuilder
    {
        private Point point1;
        private Point point2;

        public void Init(Point point)
        {
            this.point1 = point;
        }

        public void Move(Point point)
        {
            this.point2 = point;
        }

        public void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawLine(pen, this.point1, this.point2);
        }

        public Shape GetProduct()
        {
            Shape shape = new Line(this.point1, this.point2, this);
            return shape;
        }
    }
}

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
        private Line line = new Line();

        public void Init(MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            this.line.MouseDown(point);
        }

        public void Move(MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            this.line.MouseMove(point);
        }

        public void Draw(PaintEventArgs e)
        {
            this.line.Draw(e);
        }

        public Shape GetProduct()
        {
            Shape shape = new Line(this.line.Point1, this.line.Point2);
            return shape;
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    /// <summary>
    /// Builder for line
    /// </summary>
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
            e.Graphics.DrawLine(new Pen(Color.Black), this.point1, this.point2);
        }

        public Shape GetProduct() => new Line(this.point1, this.point2, this);

    }
}

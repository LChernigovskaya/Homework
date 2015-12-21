using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    abstract class Shape
    {
        public bool Selected { get;  set; }
        public bool Visible { get; set; }
        public ShapeBuilder Builder { get; protected set; }
        public Point InitPoint { get; protected set; }
        public Point SelectedPoint { get; protected set; }

        public abstract void Draw(PaintEventArgs e);
        public abstract bool Contain(Point point);
        public abstract void Move(Shape shape);
    }
}

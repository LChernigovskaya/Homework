using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    /// <summary>
    /// Interface for shapes
    /// </summary>
    abstract class Shape
    {
        public bool Selected { get;  set; }
        public bool Visible { get; set; }
        public ShapeBuilder Builder { get; protected set; }
        public Point InitPoint { get; protected set; }
        public Point SelectedPoint { get; protected set; }

        /// <summary>
        /// Draw shape
        /// </summary>
        public abstract void Draw(PaintEventArgs e);

        /// <summary>
        /// Point is contained on line or not
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public abstract bool Contain(Point point);
    }
}

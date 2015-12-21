using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    /// <summary>
    /// Null object for initialize null builder
    /// </summary>
    class NullBuilder : ShapeBuilder
    {
        public void Init(Point point) { }
        public void Move(Point point) { }
        public void Draw(PaintEventArgs e) { }
        public Shape GetProduct()
        {
            return null;
        }
    }
}
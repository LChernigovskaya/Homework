using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    interface ShapeBuilder
    {
        void Init(Point point);
        void Move(Point point);
        void Draw(PaintEventArgs e);
        Shape GetProduct();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    interface ShapeBuilder
    {
        void Init(MouseEventArgs e);
        void Move(MouseEventArgs e);
        void Draw(PaintEventArgs e);
        Shape GetProduct();
    }
}

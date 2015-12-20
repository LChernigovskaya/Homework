using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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

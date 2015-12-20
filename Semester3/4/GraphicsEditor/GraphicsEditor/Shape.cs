using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    interface Shape
    {
        void SetSelected(bool selected);
        void MouseDown(Point firstCoord);
        void MouseMove(Point secondCoord);
        void Draw(PaintEventArgs e);
        bool Contain(MouseEventArgs e);
    }
}

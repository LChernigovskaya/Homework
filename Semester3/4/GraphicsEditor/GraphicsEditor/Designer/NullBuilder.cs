using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicsEditor
{
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
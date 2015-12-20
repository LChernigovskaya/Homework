using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class NullBuilder : ShapeBuilder 
    {
        public void Init(MouseEventArgs e) { }
        public void Move(MouseEventArgs e) { }
        public void Draw(PaintEventArgs e) { }
        public Shape GetProduct()
        {
            return null;
        }
    }
}

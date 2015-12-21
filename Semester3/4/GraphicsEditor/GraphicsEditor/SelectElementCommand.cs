using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicsEditor
{
    class SelectElementCommand : Command
    {
        private MouseEventArgs e;
        private Shape newCurrentElement = null;
        private Shape previousCurrentElement = null;

        public SelectElementCommand(MouseEventArgs e)
        {
            this.e = e;
        }

        public override void Execute(Model model)
        {
            model.SetCurrentElement(this.newCurrentElement);
        }

        public override void UnExecute(Model model)
        {
            model.SetCurrentElement(this.previousCurrentElement);
        }

        public override bool IsReversible(Model model)
        {
            this.previousCurrentElement = model.GetCurrentElement();
            this.newCurrentElement = model.FindIntersection(new Point(this.e.X, this.e.Y));
            return (this.previousCurrentElement != this.newCurrentElement); 
        }
    }
}

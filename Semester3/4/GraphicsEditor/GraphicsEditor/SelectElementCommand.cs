using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class SelectElementCommand : Command
    {
        private MouseEventArgs e;
        private Shape newCurrentElement = null;
        private Shape oldCurrentElement = null;

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
            model.SetCurrentElement(this.oldCurrentElement);
        }

        public override bool IsReversible(Model model)
        {
            this.oldCurrentElement = model.GetCurrentElement();
            this.newCurrentElement = model.FindIntersection(this.e);
            return (this.oldCurrentElement != this.newCurrentElement); 
        }
    }
}

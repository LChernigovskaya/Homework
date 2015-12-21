using System.Drawing;
using System.Windows.Forms;

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

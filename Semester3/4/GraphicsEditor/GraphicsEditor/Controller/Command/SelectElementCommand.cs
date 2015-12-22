using System.Drawing;

namespace GraphicsEditor
{
    /// <summary>
    /// Changes selection of shape
    /// </summary>
    class SelectElementCommand : Command
    {
        private Point point;
        private Shape newCurrentElement = null;
        private Shape previousCurrentElement = null;

        /// <param name="point">Point on the scene</param>
        public SelectElementCommand(Point point)
        {
            this.point = point;
        }

        public override void Execute(Model model)
        {
            model.SetCurrentElement(this.newCurrentElement);
        }

        public override void Unexecute(Model model)
        {
            model.SetCurrentElement(this.previousCurrentElement);
        }
        
        /// <summary>
        /// Checks if shape was clicked repeatedly
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public override bool Significant(Model model)
        {
            this.previousCurrentElement = model.GetCurrentElement();
            this.newCurrentElement = model.FindIntersection(point);
            return (this.previousCurrentElement != this.newCurrentElement); 
        }
    }
}

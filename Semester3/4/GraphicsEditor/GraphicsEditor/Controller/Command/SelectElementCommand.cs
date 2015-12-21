using System.Drawing;

namespace GraphicsEditor
{
    /// <summary>
    /// Changes selected shape
    /// </summary>
    class SelectElementCommand : Command
    {
        private Point point;
        private Shape newCurrentElement = null;
        private Shape previousCurrentElement = null;

        /// <param name="point">pressed point</param>
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
        /// Checkes shapes are equal or not
        /// </summary>
        /// <returns></returns>
        public override bool Significant(Model model)
        {
            this.previousCurrentElement = model.GetCurrentElement();
            this.newCurrentElement = model.FindIntersection(point);
            return (this.previousCurrentElement != this.newCurrentElement); 
        }
    }
}

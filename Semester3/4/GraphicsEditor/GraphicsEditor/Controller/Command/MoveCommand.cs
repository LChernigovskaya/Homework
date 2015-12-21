namespace GraphicsEditor
{
    /// <summary>
    /// Moves shape
    /// </summary>
    class MoveCommand : Command
    {
        /// <summary>
        /// Shape after moving
        /// </summary>
        private Shape newElement;

        /// <summary>
        /// Shape before moving
        /// </summary>
        private Shape previousElement;

        public MoveCommand(Shape newElement)
        {
            this.newElement = newElement;
        }
        
        public override void Execute(Model model)
        {
            this.previousElement = model.GetCurrentElement();
            model.RemoveCurrentElement();
            model.AddElement(newElement);
        }
        
        public override void Unexecute(Model model)
        {
            model.RemoveElement(newElement);
            model.AddElement(previousElement);
        }
    }
}

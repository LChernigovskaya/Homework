namespace GraphicsEditor
{
    /// <summary>
    /// Responsible for moving shape
    /// </summary>
    class MoveCommand : Command
    {
        private Shape newElement;
        private Shape previousElement;

        public MoveCommand(Shape newElement)
        {
            this.newElement = newElement;
        }

        /// <summary>
        /// Keeps current element, removes it and adds new element
        /// </summary>
        public override void Execute(Model model)
        {
            this.previousElement = model.GetCurrentElement();
            model.RemoveCurrentElement();
            model.AddElement(newElement);
        }

        /// <summary>
        /// Removes added element and adds in model old element
        /// </summary>
        public override void Unexecute(Model model)
        {
            model.RemoveElement(newElement);
            model.AddElement(previousElement);
        }
    }
}

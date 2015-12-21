namespace GraphicsEditor
{
    /// <summary>
    /// Add new shape in model
    /// </summary>
    class AddCommand : Command
    {
        private Shape shape;

        public AddCommand(Shape newShape)
        {
            this.shape = newShape;
        }

        public override void Execute(Model model)
        {
            model.AddElement(this.shape);
        }

        /// <summary>
        /// Remove added element
        /// </summary>
        public override void Unexecute(Model model)
        {
            model.RemoveElement(this.shape);
        }
    }
}

namespace GraphicsEditor
{
    /// <summary>
    /// Adds a new shape
    /// </summary>
    class AddCommand : Command
    {
        private Shape shape;

        /// <summary>
        /// Inits a new shape
        /// </summary>
        public AddCommand(Shape newShape)
        {
            this.shape = newShape;
        }

        public override void Execute(Model model)
        {
            model.AddElement(this.shape);
        }
        
        public override void Unexecute(Model model)
        {
            model.RemoveElement(this.shape);
        }
    }
}

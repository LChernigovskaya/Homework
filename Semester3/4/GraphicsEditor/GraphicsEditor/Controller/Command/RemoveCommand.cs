namespace GraphicsEditor
{
    /// <summary>
    /// Removes current element; keeps it
    /// </summary>
    class RemoveCommand : Command
    {
        private Shape removedElement = null;

        public override void Execute(Model model)
        {
            this.removedElement = model.GetCurrentElement();
            if (removedElement != null)
            {
                model.RemoveCurrentElement();
            }
        }

        public override void Unexecute(Model model)
        {
            model.AddElement(this.removedElement);
        }
    }
}

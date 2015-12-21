
namespace GraphicsEditor
{
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

        public override void UnExecute(Model model)
        {
            model.AddElement(this.removedElement);
        }
    }
}

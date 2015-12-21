
namespace GraphicsEditor
{
    class MoveCommand : Command
    {
        private Shape newElement;
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

        public override void UnExecute(Model model)
        {
            model.RemoveElement(newElement);
            model.AddElement(previousElement);
        }
    }
}

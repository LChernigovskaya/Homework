
namespace GraphicsEditor
{
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

        public override void UnExecute(Model model)
        {
            model.RemoveElement(this.shape);
        }
    }
}

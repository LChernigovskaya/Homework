
namespace GraphicsEditor
{
    abstract class Command
    {
        public abstract void Execute(Model model);
        public abstract void UnExecute(Model model);
        public virtual bool IsReversible(Model model)
        {
            return true;
        }
    }
}

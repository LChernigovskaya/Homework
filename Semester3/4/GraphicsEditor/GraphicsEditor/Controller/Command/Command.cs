namespace GraphicsEditor
{
    /// <summary>
    /// Interface for commands
    /// </summary>
    abstract class Command
    {
        public abstract void Execute(Model model);
        public abstract void Unexecute(Model model);
        public virtual bool Significant(Model model)
        {
            return true;
        }
    }
}
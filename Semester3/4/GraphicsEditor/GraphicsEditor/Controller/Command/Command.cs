namespace GraphicsEditor
{
    /// <summary>
    /// Interface for commands
    /// </summary>
    abstract class Command
    {
        public abstract void Execute(Model model);

        public abstract void Unexecute(Model model);

        /// <summary>
        /// Checks if the command contains significant information (for example, if user clicked on empty place)
        /// </summary>
        public virtual bool Significant(Model model) => true;
    }
}
using System.Collections.Generic;

namespace GraphicsEditor
{
    /// <summary>
    /// Keeps list of commands
    /// </summary>
    class Controller
    {
        private List<Command> undoRedo = new List<Command>();
        private int pointer = -1;
        private Model model;

        public Controller(Model model)
        {
            this.model = model;
        }

        /// <summary>
        /// Add new command in list
        /// </summary>
        public void Push(Command command)
        {
            if (command.Significant(this.model))
            {
                this.pointer++;
                this.undoRedo.Insert(pointer, command);
                command.Execute(this.model);
            }
        }

        /// <summary>
        /// Unexecute previous command
        /// </summary>
        public void Redo()
        {
            if (pointer > -1)
            {
                this.undoRedo[pointer].Unexecute(this.model);
                pointer--;
            }
        }

        /// <summary>
        /// Execute next command in list
        /// </summary>
        public void Undo()
        {
            if (pointer < this.undoRedo.Count)
            {
                pointer++;
                this.undoRedo[pointer].Execute(this.model);
            }
        }
    }
}

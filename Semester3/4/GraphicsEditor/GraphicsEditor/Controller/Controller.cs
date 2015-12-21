using System.Collections.Generic;

namespace GraphicsEditor
{
    /// <summary>
    /// Operates with sequence of commands
    /// </summary>
    class Controller
    {
        private List<Command> undoRedoList = new List<Command>();
        private int pointer = -1;
        private Model model;

        public Controller(Model model)
        {
            this.model = model;
        }

        /// <summary>
        /// Checks if the command isn't mock, adds it to sequence of command and executes it
        /// </summary>
        /// <param name="command"></param>
        public void Handle(Command command)
        {
            if (command.Significant(this.model))
            {
                this.pointer++;
                this.undoRedoList.Insert(pointer, command);
                command.Execute(this.model);

                CleanListTail();
            }
        }
        
        /// <summary>
        /// Cancels the last command
        /// </summary>
        public void Redo()
        {
            if (pointer > -1)
            {
                this.undoRedoList[pointer].Unexecute(this.model);
                pointer--;
            }
        }
        
        /// <summary>
        /// Executes the next command
        /// </summary>
        public void Undo()
        {
            if (pointer < this.undoRedoList.Count - 1)
            {
                pointer++;
                this.undoRedoList[pointer].Execute(this.model);
            }
        }

        private void CleanListTail()
        {
            for (int i = pointer + 1; i < undoRedoList.Count; i++)
            {
                undoRedoList.RemoveAt(i);
            }
        }
    }
}

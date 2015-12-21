using System.Collections.Generic;

namespace GraphicsEditor
{
    class Controller
    {
        private List<Command> undoRedo = new List<Command>();
        private int pointer = -1;
        private Model model;

        public Controller(Model model)
        {
            this.model = model;
        }

        public void AddNewCommand(Command command)
        {
            if (command.IsReversible(this.model))
            {
                this.pointer++;
                this.undoRedo.Insert(pointer, command);
                command.Execute(this.model);
            }
        }

        public void Redo()
        {
            if (pointer > -1)
            {
                this.undoRedo[pointer].UnExecute(this.model);
                pointer--;
            }
        }

        public void Undo()
        {
            if (pointer < this.undoRedo.Count - 1)
            {
                pointer++;
                this.undoRedo[pointer].Execute(this.model);
            }
        }
    }
}

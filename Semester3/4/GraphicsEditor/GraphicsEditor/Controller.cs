using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Controller
    {
        private Command[] undoRedo = new Command[1000];
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
                this.undoRedo[pointer] = command;
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
            if (pointer < this.undoRedo.Length - 1)
            {
                pointer++;
                this.undoRedo[pointer].Execute(this.model);
            }
        }
    }
}

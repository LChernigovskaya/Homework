using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Controller
    {/*
        private Editor editor;
        private List<Command> undoRedo = new List<Command>();
        private int pointer = -1;

        public void AddNewCommand(Command command)
        {
            this.undoRedo.Add(command);
            editor.redo.Enabled = true;
        }

        public void Redo()
        {
            this.undoRedo[pointer].UnExecute();
            pointer--;
            if (pointer == -1)
            {
                editor.redo.Enabled = false;
            }
            if (!editor.undo.Enabled)
            {
                editor.undo.Enabled = true;
            }
        }

        public void Undo()
        {
            pointer++;
            this.undoRedo[pointer].Execute();
            if (pointer == undoRedo.Count - 1)
            {
                editor.undo.Enabled = false;
            }
            if (!editor.redo.Enabled)
            {
                editor.redo.Enabled = true;
            }
        }*/
    }
}

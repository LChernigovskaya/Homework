using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

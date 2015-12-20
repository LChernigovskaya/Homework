using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    interface Command
    {
        void Execute();
        void UnExecute();
    }
}

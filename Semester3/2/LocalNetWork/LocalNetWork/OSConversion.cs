using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    /// <summary>
    /// Converse from string to operation system
    /// </summary>
    class OSConversion
    {
        public OperationSystem os { get; private set; }

        public OSConversion(string operationSystem)
        {
            switch (operationSystem)
            {
                case ("linux"):
                    os = new OSLinux();
                    break;
                case ("windows"):
                    os = new OSWindows();
                    break;
                case ("mac"):
                    os = new OSMac();
                    break;
                default:
                    throw new Exception("operation system is uncorrect");
            }
        }
    }
}

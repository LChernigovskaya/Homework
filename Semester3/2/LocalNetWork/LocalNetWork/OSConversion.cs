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
        public static OperationSystem Convert(string operationSystem)
        {
            switch (operationSystem)
            {
                case ("linux"):
                    return new OSLinux();
                case ("windows"):
                    return new OSWindows();
                case ("mac"):
                    return new OSMac();
                default:
                    throw new Exception("operation system is incorrect");
            }
        }
    }
}

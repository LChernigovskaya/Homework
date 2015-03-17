using System;

namespace Task1
{
    /// <summary>
    /// Exception for parse tree
    /// </summary>
    [Serializable]
    public class ExceptionTree : ApplicationException
    {
        public ExceptionTree() 
        { 
        }

        public ExceptionTree(string message) 
            : base(message) 
        { 
        }
    }
}

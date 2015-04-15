using System;

namespace Task1
{
    /// <summary>
    /// Exception for parse tree
    /// </summary>
    [Serializable]
    public class TreeException : ApplicationException
    {
        public TreeException() 
        { 
        }

        public TreeException(string message) 
            : base(message) 
        { 
        }
    }
}

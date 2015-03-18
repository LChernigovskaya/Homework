using System;

namespace ListNamespace
{
    [Serializable]
    public class ListException : ApplicationException
    {
        public ListException()
        {
        }

        public ListException(string message)
            : base(message)
        {
        }
    }
}

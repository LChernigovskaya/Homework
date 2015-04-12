using System;

namespace UniqueListNamespace
{
    public class ExceptionAdd : ApplicationException
    {
        public ExceptionAdd()
        {
        }

        public ExceptionAdd(string message)
            : base(message)
        {
        }
    }
}

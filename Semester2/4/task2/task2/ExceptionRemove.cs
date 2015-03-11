using System;

namespace UniqueListNamespace
{
    public class ExceptionRemove : ApplicationException
    {
        public ExceptionRemove()
        {
        }

        public ExceptionRemove(string message)
            : base(message)
        {
        }
    }

}

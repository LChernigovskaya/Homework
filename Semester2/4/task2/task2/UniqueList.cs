using System;
using ListNamespace;

namespace UniqueListNamespace
{
    public class UniqueList : List
    {
        public UniqueList()
        {
        }

        public override void AddInOrder(int value)
        {
            if (Exists(value))
                throw new ExceptionAdd("This element already exists in list");
            else
                base.AddInOrder(value);
        }

        public override void RemoveElement(int value)
        {
            if (!Exists(value))
                throw new ExceptionRemove("This element does not exist in list");
            else
                base.RemoveElement(value);
        }
    }
}

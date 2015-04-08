using System;
using ListNamespace;

namespace UniqueListNamespace
{
    /// <summary>
    /// List without repeating elements
    /// </summary>
    public class UniqueList : List
    {
        public UniqueList()
        {
        }

        /// <summary>
        /// Add new element without repetition
        /// </summary>
        /// <param name="value">Element to be added</param>
        public override void AddInOrder(int value)
        {
            if (Exists(value))
            {
                throw new ExceptionAdd("This element already exists in list");
            }
            else
            {
                base.AddInOrder(value);
            }
        }

        /// <summary>
        /// Remove element with a certain value
        /// </summary>
        /// <param name="value">Element to be deleted</param>
        public override void RemoveElement(int value)
        {
            if (!Exists(value))
            {
                throw new ExceptionRemove("This element does not exist in list");
            }
            else
            {
                base.RemoveElement(value);
            }
        }
    }
}

using System;
using ListNamespace;

namespace FunctionsNamespace
{
    public class MapClass
    {
        /// <summary>
        /// Change all elements in list
        /// </summary>
        /// <param name="list">List to be changed</param>
        /// <param name="function">Function, which changes elements</param>
        /// <returns>New list</returns>
        public static List<int> Map(List<int> list, Func<int, int> function)
        {
            List<int> convertedList = new List<int>();
            for (int i = 0; i < list.Size; i++)
            {
                convertedList.AddTail(function((list.ReturnValue(i))));
            }
            return convertedList;
        }
    }
}

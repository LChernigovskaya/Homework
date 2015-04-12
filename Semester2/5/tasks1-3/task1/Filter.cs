using System;
using ListNamespace;

namespace FunctionsNamespace
{
    public class FilterClass
    {
        /// <summary>
        /// Filter elements of the list
        /// </summary>
        /// <param name="list">List to be filtered</param>
        /// <param name="function">Filter function</param>
        /// <returns>Filtered list</returns>
        public static List<int> Filter(List<int> list, Func<int, bool> function)
        {
            List<int> convertedList = new List<int>();
            for (int i = 0; i < list.Size; i++)
            {
                var element = list.ReturnValue(i);
                if (function(element))
                    convertedList.AddTail(element);
            }
            return convertedList;
        }
    }
}

using System;
using ListNamespace;

namespace FunctionsNamespace
{
    public class FoldClass
    {
        /// <summary>
        /// Function application consistently to all elements in list
        /// </summary>
        /// <param name="list">List, which we use</param>
        /// <param name="first">The initial value</param>
        /// <param name="function">Function, which we apply to the elements of list</param>
        /// <returns>Result</returns>
        public static int Fold(List<int> list, int first, Func<int, int, int> function)
        {
            int result = first;
            for (int i = 0; i < list.Size; i++)
            {
                result = function(result, list.ReturnValue(i));
            }
            return result;
        }
    }
}

using System;
using ListNamespace;

namespace FunctionsNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddTail(1);
            list.AddTail(2);
            list.AddTail(3);

            List<int> newlist = MapClass.Map(list, x => x * x);
            newlist.PrintList();

            List<int> nlist = FilterClass.Filter(list, x => (x % 2 == 0));
            nlist.PrintList();

            Console.WriteLine(FoldClass.Fold(list, 1, (acc, elem) => acc * elem));
        }
    }
}

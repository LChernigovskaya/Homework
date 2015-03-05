using System;

namespace ListNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.AddInOrder(7);
            list.AddInOrder(8);
            list.AddInOrder(2);
            list.AddInOrder(9);
            list.PrintList();
            list.RemoveElement(2);
            list.AddInOrder(5);
            list.PrintList();
            Console.WriteLine(list.Size);
            Console.WriteLine(list.ReturnValue(0));
        }
    }
}

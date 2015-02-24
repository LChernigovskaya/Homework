using System;

namespace Task2
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
            list.RemoveElement(8);
            list.AddInOrder(5);
            Console.WriteLine(list.Size);
        }
    }
}

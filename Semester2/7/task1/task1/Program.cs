using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListNamespace;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.AddToPosition(1, 0);
            list.AddToPosition(2, 1);
            list.AddToPosition(3, 1);

            list.PrintList();
            Console.WriteLine(list.Exists(3));

            list.RemoveElement(3);

            list.PrintList();
            Console.WriteLine(list.Exists(3));
        }
    }
}

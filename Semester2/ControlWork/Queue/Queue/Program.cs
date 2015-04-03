using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue queue = new PriorityQueue();
            try
            {
                //queue.Dequeue();
                queue.Enqueue(7, 2);
                queue.Enqueue(5, 1);
                queue.Enqueue(3, 2);
                queue.Enqueue(8, 4);
                queue.PrintQueue();
                queue.Dequeue();
                queue.PrintQueue();
            }

            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

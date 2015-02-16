using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input the index");
            int index = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(Fibonachi(index));
        }

          static int Fibonachi(int index)
        {
            if (index == 0 || index == 1)
                return 1;
            else
            {
                int a = 1;
                int b = 1;
                int result = 0;
                for (int i = 2; i <= index; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
                return result;
            }
        }
    }
}

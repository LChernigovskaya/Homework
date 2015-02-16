using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input the number");
            long number = System.Convert.ToInt64(System.Console.ReadLine());
            System.Console.WriteLine(Factorial(number));
        }

        static long Factorial(long number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
    }
}

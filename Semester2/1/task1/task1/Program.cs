using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input the number");
            int number = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(Factorial(number));
        }

        static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
    }
}

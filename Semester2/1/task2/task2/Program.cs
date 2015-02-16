using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input the index");
            int index = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(Fibonacci(index));
        }
        
        static int Fibonacci(int index)
        {
            if (index == 0 || index == 1)
                return 1;
            else
            {
                int currentFibonacciNumber = 1;
                int previousFibonacciNumber = 1;
                int auxilary = 0;
                for (int i = 2; i <= index; i++)
                {
                    auxilary = currentFibonacciNumber;
                    currentFibonacciNumber = currentFibonacciNumber + previousFibonacciNumber;
                    previousFibonacciNumber = auxilary;
                }
                return currentFibonacciNumber;
            }
        }
    }
}

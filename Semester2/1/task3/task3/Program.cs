using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the array of numbers");
            string[] num = Console.ReadLine().Split(' ');
            double[] numbers = new double[num.Length];
            for (int i = 0; i < num.Length; i++)
                numbers[i] = Double.Parse(num[i]);
            InsertionSort(numbers);
            for(int i = 0; i < numbers.Length; i++)
                Console.Write("{0} {1}", numbers[i], "");
        }

        static void InsertionSort(double[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
                while ((i > 0) && (numbers[i] < numbers[i - 1]))
                {
                    Swap(numbers, i, i - 1);
                    i--;
                }
        }

        static void Swap(double[] numbers, int i, int j)
        {
            double a = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = a;
        }
    }
}

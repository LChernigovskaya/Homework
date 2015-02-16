using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the size of array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the array of numbers");
            int[,] numbers = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                string enterString = Console.ReadLine();
                string[] massiveString = enterString.Split(new Char[] { ' ' });
                for (int j = 0; j < massiveString.Length; j++)
                {
                    numbers[i, j] = int.Parse(massiveString[j]);
                }
            }
            RoundOnASpiral(numbers, size);
        }

        static void RoundOnASpiral(int[,] numbers, int size)
        {
            int i = size / 2;
            int j = size / 2;
            Console.Write(numbers[i, j] + " ");

            // one element matrix
            if (i == 0 && j == 0)
                return;
            
            //other cases
            Console.Write(numbers[i - 1, j] + " ");
            i--;


            for (int k = 1; k <= size / 2 ; k++)
            {
                while (j < size / 2 + k)
                {
                    j++;
                    Console.Write(numbers[i, j] + " ");
                }

                while (i < size / 2 + k)
                {
                    i++;
                    Console.Write(numbers[i, j] + " ");
                }

                while (j > size / 2 - k)
                {
                    j--;
                    Console.Write(numbers[i, j] + " ");
                }

                while (i > size / 2 - k)
                {
                    i--;
                    Console.Write(numbers[i, j] + " ");
                }
            }
        }
    }
}
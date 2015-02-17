using System;

namespace Task7
{
    class Program
    {
        public struct InitialPositionInfo
        {
            public double value;
            public int numberOfColumn;

            public InitialPositionInfo(double firstColumnElement, int column)
            {
                value = firstColumnElement;
                numberOfColumn = column;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of strings");
            int strings = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the number of columns");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the array of numbers");
            double[,] numbers = new double[strings, columns];
            for (int i = 0; i < strings; i++)
            {
                string enterString = Console.ReadLine();
                string[] massiveString = enterString.Split(new Char[] { ' ' });
                for (int j = 0; j < massiveString.Length; j++)
                {
                    numbers[i, j] = double.Parse(massiveString[j]);
                }
            }
            Console.WriteLine();

            SortColumns(numbers);
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                    Console.Write(numbers[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void SortColumns(double[,] matrix)
        {
            InitialPositionInfo[] arrayOfInitialPosition = new InitialPositionInfo[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                arrayOfInitialPosition[j].value = matrix[0, j];
                arrayOfInitialPosition[j].numberOfColumn = j;
            }
            //Sort the first elements of columns, remembering initial column positions
            InsertionSort(arrayOfInitialPosition);

            //Change columns, using information about initial positions
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (arrayOfInitialPosition[j].numberOfColumn != j)
                {
                    ChangeColumn(matrix, j, arrayOfInitialPosition[j].numberOfColumn);
                    for (int k = j + 1; k < matrix.GetLength(1) - 1; k++)
                        if (arrayOfInitialPosition[k].value == matrix[0, arrayOfInitialPosition[j].numberOfColumn])
                        {
                            arrayOfInitialPosition[k].numberOfColumn = arrayOfInitialPosition[j].numberOfColumn;
                            break;
                        }
                }
            }
        }

        static void InsertionSort(InitialPositionInfo[] numbers)
        {
            for (int i = 1; i < numbers.GetLength(0); i++)
                while ((i > 0) && (numbers[i].value < numbers[i - 1].value))
                {
                    Swap(numbers, i, i - 1);
                    i--;
                }
        }

        static void Swap(InitialPositionInfo[] numbers, int theFirstElement, int theSecondElement)
        {
            InitialPositionInfo auxilary = numbers[theFirstElement];
            numbers[theFirstElement] = numbers[theSecondElement];
            numbers[theSecondElement] = auxilary;
        }

        static void ChangeColumn(double[,] matrix, int firstColumn, int secondColumn)
        {
            int height = matrix.GetLength(0);
            for (int i = 0; i < height; i++)
            {
                double auxilaryElement = matrix[i, firstColumn];
                matrix[i, firstColumn] = matrix[i, secondColumn];
                matrix[i, secondColumn] = auxilaryElement;
            }
        }
    }
}

using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            StreamReader stReader = new StreamReader("calculate.txt");
            try
            {
                tree.PutInTree(stReader, tree);
                tree.PrintTree();
                Console.WriteLine("Result = " + tree.Result());
            }
            catch (TreeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                stReader.Close();
            }
        }
    }
}
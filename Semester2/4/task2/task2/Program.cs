using System;

namespace UniqueListNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueList list = new UniqueList();
            try
            {
                list.AddInOrder(2);
                list.AddInOrder(9);
                list.AddInOrder(2);
                list.RemoveElement(7);
                list.PrintList();
            }
            catch (ExceptionAdd exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ExceptionRemove exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

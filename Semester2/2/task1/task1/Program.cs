using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine(stack.IsEmpty());
            stack.Push(5);
            stack.Push(1);
            stack.Push(15);
            stack.PrintStack();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
            stack.Push(55);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
            stack.PrintStack();
        }
    }
}

using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc1 = new Calc(new LinkedStack<double> ());
            Console.WriteLine("Input an expresion in postfix form");
            string enterString1 = Console.ReadLine();
            string[] massiveString1 = enterString1.Split(new Char[] { ' ' });
            for (int j = 0; j < massiveString1.Length; j++)
                calc1.Calculate(massiveString1[j]);
            Console.WriteLine(calc1.ShowResult());

            Calc calc2 = new Calc(new ArrayStack<double>(100));
            Console.WriteLine("Input an expresion in postfix form");
            string enterString2 = Console.ReadLine();
            string[] massiveString2 = enterString2.Split(new Char[] { ' ' });
            for (int j = 0; j < massiveString2.Length; j++)
                calc2.Calculate(massiveString2[j]);
            Console.WriteLine(calc2.ShowResult()); 
        }
    }
}

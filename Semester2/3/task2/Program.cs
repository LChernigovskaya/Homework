using System;
using System.IO;

namespace HashNamespace
{
    class Program
    {
        public enum HashType{polynom, sum};

        static void Main(string[] args)
        {
            Console.WriteLine("Chose the hash function:\n0 - expansion in powers\n1 - sum");
            int choosenHash = Console.Read() - '0';

            InterfaceHashTable hash;

            if (choosenHash == (int)HashType.polynom)
            {
                 hash = new HashFunctionPolynom(97);
            }
            else
            {
                 hash = new HashFunctionSum(97);
            }

            string[] file = File.ReadAllLines("hash.txt");

            for (int i = 0; i < file.Length; i++)
            {
                string[] massiveString = file[i].Split(new [] { ' ' });
                for (int j = 0; j < massiveString.Length; j++)
                {
                    string str = massiveString[j];
                    str = str.ToLower();
                    str = str.TrimStart('\"', '\'');
                    str = str.TrimStart('\"', '\''); ;
                    str = str.TrimEnd('.', ',', ';', '!', '?', '\'', '\"');
                    str = str.TrimEnd('.', ',', '!', ';', '?', '\'', '\"');
                    hash.AddElement(str);
                }
            }
           hash.PrintStatistic();
        }
    }
}

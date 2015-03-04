using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceHashTable hash = new HashTable(97);

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
            Console.WriteLine(hash.IsExist("it"));
            hash.PrintList("it");
            hash.RemoveElement("it");
            Console.WriteLine(hash.IsExist("it"));
            hash.PrintList("it");
            hash.RemoveElement("feelings");
            Console.WriteLine(hash.IsExist("feelings"));
        }
    }
}

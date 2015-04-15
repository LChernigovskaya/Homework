using System;
using System.IO;

namespace Task1
{
    /// <summary>
    /// Parse tree
    /// </summary>
    public class Tree
    {
        /// <summary>
        /// Root of tree
        /// </summary>
        private TreeElement root = null;

        /// <summary>
        /// Print in the form: (operand operator operand)
        /// </summary>
        public void PrintTree()
        {
            root.Print();
            Console.WriteLine();
        }

        /// <summary>
        /// Calculate the expression
        /// </summary>
        /// <returns>Result of calculating</returns>
        public double Result()
        {
            return root.Calculate();
        }

        /// <summary>
        /// It is operand or not
        /// </summary>
        private static bool Number(string value)
        {
            int res;
            return Int32.TryParse(value, out res);
        }

        /// <summary>
        /// It is operation or not
        /// </summary>
        private static bool Operation(string value)
        {
            return (value == "+" || value == "-" || value == "*" || value == "/");
        }

        /// <summary>
        /// Add elements in tree
        /// </summary>
        /// <param name="massiveString">Expression</param>
        /// <param name="index">Index of element of expression</param>
        /// <returns>Root of the tree</returns>
        public TreeElement Put(string[] massiveString, ref int index)
        {
            if (index >= massiveString.Length)
            {
                throw new TreeException("Incorrect expression: the number of operations more than the number of arguments");
            }

            else if (massiveString[index] == "")
            {
                index++;
                return Put(massiveString, ref index);
            }

            else if (Operation(massiveString[index]))
            {
                string value = massiveString[index];
                index++;
                TreeElement left = Put(massiveString, ref index);
                index++;
                TreeElement right = Put(massiveString, ref index);

                switch (value)
                {
                    case "+":
                        return new Addition(left, right);
                    case "-":
                        return new Substraction(left, right);
                    case "*":
                        return new Multiplication(left, right);
                    case "/":
                        return new Division(left, right);
                }

                return null;
            }

            else if (Number(massiveString[index]))
            {
                return new Operand(massiveString[index]);
            }

            else throw new TreeException("Incorrect expression");
        }

        /// <summary>
        /// Convert the text in array and make a tree, using expression in the text
        /// </summary>
        /// <param name="file"></param>
        /// <param name="tree"></param>
        public void PutInTree(StreamReader file, Tree tree)
        {
            string input = file.ReadToEnd();
            string[] massiveString = input.Split(new char[] { ' ' });
            for (int j = 0; j < massiveString.Length; j++)
            {
                string massuveString = massiveString[j];
                massiveString[j] = massiveString[j].TrimStart('('); ;
                massiveString[j] = massiveString[j].TrimEnd(')');
            }

            int index = 0;
            root = Put(massiveString, ref index);
            if (index + 1 < massiveString.Length)
            {
                throw new TreeException("Incorrect expression: the number of arguments more than the number of operations");
            }
        }
    }
}

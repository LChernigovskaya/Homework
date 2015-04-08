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
        public bool Number(string value)
        {
            int res;
            return Int32.TryParse(value, out res);
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
                throw new ExceptionTree("Incorrect expression: the number of operations more than the number of arguments");
            {
                if (massiveString[index] == "")
                {
                    index++;
                    return Put(massiveString, ref index);
                }

                else if (massiveString[index] == "+")
                {
                    index++;
                    TreeElement left = Put(massiveString, ref index);
                    index++;
                    TreeElement right = Put(massiveString, ref index);
                    return new Addition("+", left, right);
                }

                else if (massiveString[index] == "-")
                {
                    index++;
                    TreeElement left = Put(massiveString, ref index);
                    index++;
                    TreeElement right = Put(massiveString, ref index);
                    return new Substraction("-", left, right);
                }

                else if (massiveString[index] == "*")
                {
                    index++;
                    TreeElement left = Put(massiveString, ref index);
                    index++;
                    TreeElement right = Put(massiveString, ref index);
                    return new Multiplication("*", left, right);
                }

                else if (massiveString[index] == "/")
                {
                    index++;
                    TreeElement left = Put(massiveString, ref index);
                    index++;
                    TreeElement right = Put(massiveString, ref index);
                    return new Devision("/", left, right);
                }

                else if (Number(massiveString[index]))
                {
                    return new Value(massiveString[index]);
                }
                else throw new ExceptionTree("Incorrect expression");
            }
            
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
                throw new ExceptionTree("Incorrect expression: the number of arguments more than the number of operations");
            }
        }
    }
}

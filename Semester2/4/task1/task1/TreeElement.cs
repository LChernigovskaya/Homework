using System;

namespace Task1
{
    /// <summary>
    /// Element of tree: leaf or node
    /// </summary>
    abstract public class TreeElement
    {
        /// <summary>
        /// Calculate the expression
        /// </summary>
        /// <returns>Result</returns>
        abstract public double Calculate();

        /// <summary>
        /// Print the expression in a form: (operand operator operand)
        /// </summary>
        abstract public void Print();
    }
}

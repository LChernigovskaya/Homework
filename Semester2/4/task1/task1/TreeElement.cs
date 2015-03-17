using System;

namespace Task1
{
    /// <summary>
    /// Element of tree: leaf or node
    /// </summary>
    abstract public class TreeElement
    {
        public TreeElement(string value, TreeElement left, TreeElement right)
        {
            this.Value = value;
            this.LeftChild = left;
            this.RightChild = right;
        }

        public string Value { get; set; }
        public TreeElement RightChild { get; set; }
        public TreeElement LeftChild { get; set; }

        /// <summary>
        /// Calculate the expression
        /// </summary>
        /// <returns>Result</returns>
        abstract public double Calculate();

        /// <summary>
        /// Print the expression
        /// </summary>
        abstract public void Print();
    }
}

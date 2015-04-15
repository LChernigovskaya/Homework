using System;

namespace Task1
{
    /// <summary>
    /// Operations: "+", "-", "*", "/"
    /// </summary>
    abstract public class Operation : TreeElement
    {
        public Operation(TreeElement left, TreeElement right)
        {
            this.RightChild = right;
            this.LeftChild = left;
        }

        public TreeElement RightChild { get; set; }
        public TreeElement LeftChild { get; set; }

        abstract override public double Calculate();

        /// <summary>
        /// Print a value of operation
        /// </summary>
        abstract public void PrintValue();

        public override void Print()
        {
            Console.Write("(");
            LeftChild.Print();
            PrintValue();
            RightChild.Print();
            Console.Write(")");
        }
    }
}
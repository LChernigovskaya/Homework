using System;

namespace Task1
{
    /// <summary>
    /// Operations: "+", "-", "*", "/"
    /// </summary>
    abstract public class Operation : TreeElement
    {
        public Operation(string value, TreeElement left, TreeElement right)
            : base(value, left, right)
        {
        }

        abstract override public double Calculate();

        /// <summary>
        /// Print in a form: (operand operator operand)
        /// </summary>
        public override void Print()
        {
            Console.Write("(");
            LeftChild.Print();
            Console.Write(Value);
            RightChild.Print();
            Console.Write(")");
        }
    }

    public class Addition : Operation
    {
        public Addition(string value, TreeElement left, TreeElement right)
            : base(value, left, right)
        { }

        public override double Calculate()
        {
            return LeftChild.Calculate() + RightChild.Calculate();
        }
    }

    public class Substraction : Operation
    {
        public Substraction(string value, TreeElement left, TreeElement right)
            : base(value, left, right)
        { }

        public override double Calculate()
        {
            return LeftChild.Calculate() - RightChild.Calculate();
        }
    }

    public class Multiplication : Operation
    {
        public Multiplication(string value, TreeElement left, TreeElement right)
            : base(value, left, right)
        { }

        public override double Calculate()
        {
            return LeftChild.Calculate() * RightChild.Calculate();
        }
    }

    public class Devision : Operation
    {
        public Devision(string value, TreeElement left, TreeElement right)
            : base(value, left, right)
        { }

        public override double Calculate()
        {
            if (RightChild.Value == "0")
            {
                throw new ExceptionTree("Devision by zero");
            }
            return LeftChild.Calculate() / RightChild.Calculate();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Class that provides addition
    /// </summary>
    class Addition : Operation
    {
        public Addition(TreeElement left, TreeElement right)
            : base (left, right)
        { }

        public override double Calculate()
        {
            return LeftChild.Calculate() + RightChild.Calculate();
        }

        public override void PrintValue()
        {
            Console.Write("+");
        }
    }
}

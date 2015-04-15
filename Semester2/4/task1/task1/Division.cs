using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Class that provides division
    /// </summary>
    public class Division : Operation
    {
        public Division(TreeElement left, TreeElement right)
            : base(left, right)
        { }

        public override double Calculate()
        {
            if (RightChild.Calculate() == 0)
            {
                throw new TreeException("Division by zero");
            }
            return LeftChild.Calculate() / RightChild.Calculate();
        }

        public override void PrintValue()
        {
            Console.Write("/");
        }
    }
}

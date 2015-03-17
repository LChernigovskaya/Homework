using System;

namespace Task1
{
    /// <summary>
    /// Operand
    /// </summary>
    public class Value : TreeElement
    {
        public Value(string value)        
            : base(value, null, null)
        { }
        
        public override double Calculate()
        {
            return Convert.ToDouble(Value);
        }

        /// <summary>
        /// Print operand
        /// </summary>
        public override void Print()
        {
            Console.Write(Value);
        }
    }
}

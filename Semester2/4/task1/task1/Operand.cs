using System;

namespace Task1
{
    /// <summary>
    /// Class that provides operand
    /// </summary>
    class Operand : TreeElement
    {
        public Operand(string value)        
        {
            this.Value = value;
        }

        public string Value { get; set; }
        
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

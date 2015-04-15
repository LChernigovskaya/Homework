using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private double firstOperand;
        private double secondOperand;
        private string operation = "";

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void OnFigureClick(object sender, EventArgs e)
        {
            var text = (Button)sender;
            expression.AppendText(text.Text);
        }

        private void OnOperationClick(object sender, EventArgs e)
        {
            var text = (Button)sender;
            if (operation == "")
            {
                firstOperand = Convert.ToDouble(expression.Text);
            }
            else
            {
                Calculate(operation);
            }
            operation = text.Text;
            expression.Clear();
        }

        private void OnResultClick(object sender, EventArgs e)
        {
            Calculate(operation);
            expression.AppendText(Convert.ToString(firstOperand));
            operation = "";
        }

        private void Calculate(string operation)
        {
            secondOperand = Convert.ToDouble(expression.Text);
            expression.Clear();
            if (operation == "+")
                firstOperand = firstOperand + secondOperand;
            if (operation == "-")
                firstOperand = firstOperand - secondOperand;
            if (operation == "*")
                firstOperand = firstOperand * secondOperand;
            if (operation == "/")
            {
                if (secondOperand == 0)
                    throw new Exception("division by zero");
                firstOperand = firstOperand / secondOperand;
            }
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            expression.Clear();
        }
    }
}
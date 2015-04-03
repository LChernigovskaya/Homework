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
        private char operation = ' ';

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void OnFigure1Click(object sender, EventArgs e)
        {
            expression.AppendText("1");
        }

        private void OnFigure2Click(object sender, EventArgs e)
        {
            expression.AppendText("2");
        }

        private void OnFigure3Click(object sender, EventArgs e)
        {
            expression.AppendText("3");
        }

        private void OnFigure4Click(object sender, EventArgs e)
        {
            expression.AppendText("4");
        }

        private void OnFigure5Click(object sender, EventArgs e)
        {
            expression.AppendText("5");
        }

        private void OnFigure6Click(object sender, EventArgs e)
        {
            expression.AppendText("6");
        }

        private void OnFigure7Click(object sender, EventArgs e)
        {
            expression.AppendText("7");
        }

        private void OnFigure8Click(object sender, EventArgs e)
        {
            expression.AppendText("8");
        }

        private void OnFigure9Click(object sender, EventArgs e)
        {
            expression.AppendText("9");
        }

        private void OnFigure0Click(object sender, EventArgs e)
        {
            expression.AppendText("0");
        }

        private void OnAdditionClick(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                firstOperand = Convert.ToDouble(expression.Text);
                operation = '+';
                expression.Clear();
            }
            else
            {
                Calculate(operation);
                operation = '+';
                expression.Clear();
            }
        }

        private void OnSubstractionClick(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                firstOperand = Convert.ToDouble(expression.Text);
                operation = '-';
                expression.Clear();
            }
            else
            {
                Calculate(operation);
                operation = '-';
                expression.Clear();
            }
        }

        private void OnMultiplicationClick(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                firstOperand = Convert.ToDouble(expression.Text);
                operation = '*';
                expression.Clear();
            }
            else
            {
                Calculate(operation);
                operation = '*';
                expression.Clear();
            }
        }

        private void OnDevisionClick(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                firstOperand = Convert.ToDouble(expression.Text);
                operation = '/';
                expression.Clear();
            }
            else
            {
                Calculate(operation);
                operation = '/';
                expression.Clear();
            }
        }

        private void OnResultClick(object sender, EventArgs e)
        {
            Calculate(operation);
            expression.AppendText(Convert.ToString(firstOperand));
            operation = ' ';
        }

        private void Calculate(char operation)
        {
            secondOperand = Convert.ToDouble(expression.Text);
            expression.Clear();
            if (operation == '+')
                firstOperand = firstOperand + secondOperand;
            if (operation == '-')
                firstOperand = firstOperand - secondOperand;
            if (operation == '*')
                firstOperand = firstOperand * secondOperand;
            if (operation == '/')
            {
                if (secondOperand == 0)
                    throw new Exception("devision by zero");
                firstOperand = firstOperand / secondOperand;
            }
        }

        private void OnPointClick(object sender, EventArgs e)
        {
            expression.AppendText(",");
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            expression.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KalkulatorXamarin
{
    public enum Operation
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide,
        Square,
        SquareRoot,
        Inverse
    }

    public partial class MainPage : ContentPage
    {
        private double a = 0;
        private double b = 0;
        private double result = 0;
        private Operation operation = Operation.None;
        private bool comma = false;
        private bool equalsClicked = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Print()
        {
            if (operation == Operation.None)
            {
                outputLabel.Text = a.ToString();
                outputEquationLabel.Text = "";
                return;
            }
            switch (operation)
            {
                case Operation.Add:
                case Operation.Subtract:
                case Operation.Multiply:
                case Operation.Divide:
                    if (equalsClicked)
                    {
                        outputEquationLabel.Text = a.ToString() + " " + OperationToSign(operation) + " " + b.ToString() + " =";
                        outputLabel.Text = result.ToString();
                    }
                    else
                    {
                        outputEquationLabel.Text = a.ToString() + " " + OperationToSign(operation);
                        outputLabel.Text = b.ToString();
                    }
                    return;
                case Operation.Square:
                    outputEquationLabel.Text = "sqr(" + a.ToString() + ")";
                    break;
                case Operation.SquareRoot:
                    outputEquationLabel.Text = "sqrt(" + a.ToString() + ")";
                    break;
                case Operation.Inverse:
                    outputEquationLabel.Text = "1/" + a.ToString();
                    break;
            }
            outputLabel.Text = result.ToString();
            a = result;
            b = 0;
            result = 0;
            comma = false;
            operation = Operation.None;
        }
        private string OperationToSign(Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return "+";
                case Operation.Subtract:
                    return "-";
                case Operation.Multiply:
                    return "x";
                case Operation.Divide:
                    return "/";
            }
            return "";
        }

        private void OperationClick(object sender, EventArgs e)
        {

        }

        private void ClearClick(object sender, EventArgs e)
        {

        }

        private void NumberClick(object sender, EventArgs e)
        {

        }

        private void EqualsClick(object sender, EventArgs e)
        {

        }

        private void CommaClick(object sender, EventArgs e)
        {
            comma = true;
        }
    }
}

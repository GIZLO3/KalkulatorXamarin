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
        public MainPage()
        {
            InitializeComponent();
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

        }
    }
}

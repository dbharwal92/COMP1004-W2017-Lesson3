using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson3
{
    public partial class CalculatorForm : Form
    {
        // Private Instance variables
        private string _oprand1;
        private  string _oprand2;
        private bool _isCalculatorClear;

        //CONSTRUCTORS +++++++++++++++++++++

        /// <summary>
        /// Default constructor
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();

            //clears the calculator
            this._clearCalculator();
        }
        // This method clears the calculator and resets the variables
         private void _clearCalculator()
        {
            this._oprand1 = "";
            this._oprand2 = "";
            this._isCalculatorClear = true;
            ResultTextBox.Text = "0";

        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button CalculatorButton = (Button)sender;
            // Button CalculatorButton = sender as Button;
           // ResultTextBox.Text += CalculatorButton.Text;
           switch (CalculatorButton.Tag.ToString())
            {
                case "Oprand":
                    if(this._isCalculatorClear)
                    {
                        ResultTextBox.Text = CalculatorButton.Text;
                        this._isCalculatorClear = false;
                    }
                    else
                    {
                        ResultTextBox.Text += CalculatorButton.Text;
                    }
                    break;
                case "Oprator":
                    break;
                case "Other":
                    break;
            }

        }

    }

}

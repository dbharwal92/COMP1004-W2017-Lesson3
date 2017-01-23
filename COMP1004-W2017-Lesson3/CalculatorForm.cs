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
        public CalculatorForm()
        {
            InitializeComponent();
        }


        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button CalculatorButton = (Button)sender;
            // Button CalculatorButton = sender as Button;
            ResultTextBox.Text += CalculatorButton.Text;

        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp_Partice_02
{
    public partial class CalculatorForm : Form
    {
        double firstnumber, secoundNumber, result;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(FirstNumberTextBox.Text);
           secoundNumber = Convert.ToDouble(SecoundNumberTextBox2.Text);
            result = firstnumber + secoundNumber;
            ResultTextBox.Text = result.ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(FirstNumberTextBox.Text);
            secoundNumber = Convert.ToDouble(SecoundNumberTextBox2.Text);
            result = firstnumber - secoundNumber;
            ResultTextBox.Text = result.ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(FirstNumberTextBox.Text);
            secoundNumber = Convert.ToDouble(SecoundNumberTextBox2.Text);
            result = firstnumber * secoundNumber;
            ResultTextBox.Text = result.ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

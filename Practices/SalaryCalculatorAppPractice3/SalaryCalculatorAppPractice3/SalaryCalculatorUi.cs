using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        Salary salary = new Salary();
        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            salary.employeName = employeeNameTextBox.Text;
            salary.basicAmount = Convert.ToInt32(basicAmountTextBox.Text);
            salary.houseRent = Convert.ToInt32(homeRentTextBox.Text);
            salary.medicalRent = Convert.ToInt32(medicalAllowanceTextBox.Text);

            MessageBox.Show("Mr." + salary.employeName + " your salary is: " + salary.TotalSalary());
        }
    }
}

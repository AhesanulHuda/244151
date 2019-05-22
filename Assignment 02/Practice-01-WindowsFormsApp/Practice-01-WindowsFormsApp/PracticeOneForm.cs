using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_01_WindowsFormsApp
{
    public partial class PracticeOneForm : Form
    {
        public PracticeOneForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ShowAllinfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:"+FirstNameTextBox.Text+"\n"+LastNameTextBox.Text+"\n"+"Father Name:"+FatherNameTextBox.Text+"\n"+"Mother Name:"+MotherNameTextBox.Text+"\n"+"Address:"+AddressTextBox.Text);
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name::" + FirstNameTextBox.Text + " " + LastNameTextBox.Text);
        }

        private void ParentsInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paresnts Info:"+"Father Name:" + FatherNameTextBox.Text + "\t" +"Mother Name:"+ MotherNameTextBox.Text);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address:" + AddressTextBox.Text);
        }
    }
}

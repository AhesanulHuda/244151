using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWindowsFormsApp
{
    public partial class CoffeShopForm : Form
    {
        string name, phnNum, add,order,quantity;
        
        public CoffeShopForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void CoffeShopForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderComboBox_Click(object sender, EventArgs e)
        {
           
        }

        private void OrderComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int hot =90, cold=100, regular=80, black=120;
            
            name = CustomerNameTextBox.Text;
            phnNum = ContactNumTextBox.Text;
            add = AddressTextBox.Text;
            quantity = QuantityTextBox.Text;
        }

        private void OrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ResultRichTextBox1.Text = "Customer Information"+"\t"+"\n"
                +"............................................................"+"\n"
                +"Customer Name:"+"\t"+name
                +"\n"
               +"\n" +
                "Contact Number:" + "\t"
                + phnNum
                +"\n"+
                "\n"+
                "Address:" + "\t" + "\t" + add +"\n" + "\n"
                 +"\n" + "\n" 
                  +"\n" + "\n" + "........................" + "\n" + "\n" +
                "Order item:" + "\t" + OrderComboBox.SelectedItem + "\n" + "\n"
                +"Order:" + "\t" + "\t" + quantity;
        } 
    }
}

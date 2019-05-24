using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopArrayWindowsFormsApp
{
    public partial class coffeShopForm : Form
    {
        
        


        public coffeShopForm()
        {
            InitializeComponent();
        }
        //variables
        const int size = 10;
        int index = 0;
        string[] customerName = new string[size];
        string[] customerContactNo = new string[size];
        string[] customerAddress = new string[size];
        string[] customerOrder = new string[size];
        int[] total = new int[size];
        int[] quantity = new int[size];
        int Black = 120, Cold = 100, Hot = 90, Regular = 80;

        string[] information = new string[size];

        

        private void button1_Click(object sender, EventArgs e)
        {
            //ArrayList of information
            information[index] = richTextBox1.Text;

            customerName[index] = customerNametextBox.Text;
            customerContactNo[index] = contactNoTextBox.Text;
            customerAddress[index] = addressTextBox.Text;
            customerOrder[index] = orderComboBox.SelectedItem.ToString();
            quantity[index] = Convert.ToInt32(quantityTextBox.Text);

            //Prices Calculation
            if (customerOrder[index]=="Black")
            {
                total[index] = quantity[index] * Black;
            }
            else if (customerOrder[index] == "Cold")
            {
                total[index] = quantity[index] * Cold;
            }
            else if (customerOrder[index] == "Hot")
            {
                total[index] = quantity[index] * Hot;
            }
            else if(customerOrder[index]=="Regular")
            {
                total[index] = quantity[index] * Regular;
            }
            else
            {
                total[index] = 000000;
            }

          //Print Customer Information
            richTextBox1.Text = "\t"+"Customer Information"+"\n"
                +"::::::::::::::::::::::::::::::::::::::::::::::::"+"\n"
                + "::::::::::::::::::::::::::::::::::::::::::::::::" + "\n"
                + "Customer Name:"+ customerName[index] + "\n"
                +"Contact No :"+ customerContactNo[index] + "\n"
                +"Address :"+ customerAddress[index] + "\n"
               + "::::::::::::::::::::::::::::::::::::::::::::::::" + "\n"

                + "Order Coffe:"+ customerOrder[index] + "\n"
                +"Item :"+ quantity[index] + "\n"
                +"Prices :"+"\t"+ total[index]
                + "\n"
               + "::::::::::::::::::::::::::::::::::::::::::::::::" + "\n"+ information[index]
                ;
        }

        private void customerNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

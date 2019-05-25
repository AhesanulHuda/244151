using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopWinApp
{
    public partial class BookShop : Form
    {
        public BookShop()
        {
            InitializeComponent();
        }

        int i =0;
        const int size = 10;
        string[] name = new string[size];
        string[] phnnum = new string[size];
        string[] add = new string[size];
        string[] order = new string[size];
        int[] pics = new int[size];
        int[] total = new int[size];
        //book prices
       int Math = 120, English = 100, Bangla = 90, Art = 80;

        string []display =new string[size];


        private void BookShop_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            name[i] = customerNameTextBox.Text;
            phnnum[i] = contactNoTextBox.Text;
            add[i] = addressTextBox.Text;
            order[i] = Convert.ToString(orderComboBox.SelectedItem);
            pics[i] = Convert.ToInt32(quantityTextBox.Text);
            display[i] = displayTextBox.Text;

            if (order[i]=="Bangla")
            {
                total[i] = Bangla * pics[i];
            }
            else if(order[i]=="English")
            {
                total[i] = English * pics[i];
            
            }
            else if (order[i]=="Art")
            {
                total[i] = Art * pics[i];
           
            }
            else if (order[i] == "Math")
            {
                total[i] = Math * pics[i];
            }
            else
            {
                total[i] = 999999999;
            }
            


            displayTextBox.Text = "Customer Information" + "\n"
             + "*******************************************" + "\n" +
             "Customer Name" + ":" + "\t" + name[i] + "\n" +
             "Customer Phone No" + ":" + "\t" + phnnum[i] + "\n" +
             "Customer Address" + ":" + "\t" + add[i] + "\n" +
             "................................................" + "\n" +
             "Book Order" + ":" + "\t" + order[i] + "\n" +
             "Quantity of Book" + ":" + "\t" + pics[i] + "\n" +
             "Total Prices of Book" + ":" + "\t" + total[i] + "\n"
              + "*******************************************" + "\n" +
               display[i] + "\n";







        }
    }
}

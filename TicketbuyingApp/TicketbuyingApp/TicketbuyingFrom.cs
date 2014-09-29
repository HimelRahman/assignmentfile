using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketbuyingApp
{
    public partial class TicketbuyingFrom : Form
    {
        public TicketbuyingFrom()
        {
            InitializeComponent();
        }
        string name;
        double price=1.0;
        double item;
        private void priceButton_Click(object sender, EventArgs e)
        {
            item= Convert.ToDouble(numberTextBox.Text);
            price =item * 10.00;
            MessageBox.Show("your total price is " +price);
        }

        private void detailshowButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            clearall();
            MessageBox.Show(name +", you buy " + item +" tickets and total price of ticket is " + price);
        }

        private void clearall()
        {
            nameTextBox.Text = string.Empty;
            numberTextBox.Text = string.Empty;
        }

        

    
    }
}

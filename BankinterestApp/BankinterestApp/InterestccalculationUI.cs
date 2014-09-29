using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankinterestApp
{
    public partial class InterestccalculationUI : Form
    {
        public InterestccalculationUI()
        {
            InitializeComponent();
        }

        string name;
        int year;
        double balance;
        double store;
        private void outputButton_Click(object sender, EventArgs e)
        {
            name = weekComboBox.Text;
            year = Convert.ToInt32(timeTextBox.Text);
            balance = Convert.ToDouble(balanceTextBox.Text);

            if (name == "BRAC")
             store =(((balance*6)*year)/100);
            else if (name == "DBBL")
                store = (((balance * 7) * year) / 100);
            else if (name == "HSBC")
                store = (((balance * 8) * year) / 100);

            outputlabel.Text =store.ToString();
        }
    }
}

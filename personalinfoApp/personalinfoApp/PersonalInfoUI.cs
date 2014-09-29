using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personalinfoApp
{
    public partial class PersonalInfoUI : Form
    {
        public PersonalInfoUI()
        {
            InitializeComponent();
        }

        Identification aPerson = new Identification();

        private void saveButton_Click(object sender, EventArgs e)
        {
            aPerson.Firstname = fnameTextBox.Text;
            aPerson.Lastname = lnameTextBox.Text;
            aPerson.Fathername = fathernameTextBox.Text;
            aPerson.Mothername = mnameTextBox.Text;
            aPerson.Address = addressTextBox.Text;
            clearall();
            MessageBox.Show("All information is saved properly");
        }

        private void clearall()
        {
            fnameTextBox.Text=string.Empty;
            lnameTextBox.Text = string.Empty;
            fathernameTextBox.Text = string.Empty;
            mnameTextBox.Text =string.Empty;
            addressTextBox.Text=string.Empty;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aPerson.Firstname + "\n" + aPerson.Lastname + "\n" + aPerson.Fathername + "\n" + aPerson.Mothername + "\n" + aPerson.Address);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Full Name: " + aPerson.Getfullname());
        }


        private void parentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father Name: " + aPerson.Fathername + "\nMother Name: " + aPerson.Mothername);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address: " + aPerson.Address);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentinfo
{
    public partial class Registrationfrom : Form
    {
        public Registrationfrom()
        {
            InitializeComponent();
        }
        student std = new student();

        private void savebutton_Click(object sender, EventArgs e)
        {
            std.reg = regtextBox.Text;
            std.firstname = fsttextBox.Text;
            std.lastname = lsttextBox.Text;
            MessageBox.Show(std.getfullname() + " ur Registration number is : " + std.reg);
        }

        private void retrivebutton_Click(object sender, EventArgs e)
        {
            regtextBox.Text =std.reg;
            fsttextBox.Text =std.firstname;
            lsttextBox.Text = std.lastname; 
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            regtextBox.Text=" ";
             fsttextBox.Text=" ";
            lsttextBox.Text=" "; 
        }
    }
}

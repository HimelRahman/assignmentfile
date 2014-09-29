using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userdefine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        emp employee = new emp();

        private void savebutton_Click(object sender, EventArgs e)
        {
            employee.id = idtextBox.Text;
            employee.name = nametextBox.Text;
            employee.salary = salarytextBox.Text;
            clearall();
        }

        private void clearall()
        {
            idtextBox.Text = " ";
            nametextBox.Text = " ";
            salarytextBox.Text = " ";
        }

        private void retrivebutton_Click(object sender, EventArgs e)
        {
            idtextBox.Text= employee.id;
            nametextBox.Text=employee.name;
            salarytextBox.Text = employee.salary;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leapyear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(inputTextBox.Text);
            if (((time % 4) == 0 && (time % 100) != 0) || (time % 400) == 0)
             outputLabel.Text= time +" is Leap Year";
            else
                outputLabel.Text = time + " is not Leap Year";
        }
    }
}

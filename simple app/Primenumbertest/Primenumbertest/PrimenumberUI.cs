using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primenumbertest
{
    public partial class PrimenumberUI : Form
    {
        public PrimenumberUI()
        {
            InitializeComponent();
        }

        int number;
        private void showButton_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(inputTextBox.Text);
            int count = 0;
            for (int index = 2; index <= number/2; index += 1)
            {
                if ((number % index) == 0)
                {
                    count = 1;
                }
            }
            if (count == 0)

                outputLabel.Text =number.ToString() +" is Prime number";
            else
                outputLabel.Text = number.ToString() + " is not Prime number";
        }
    }
}

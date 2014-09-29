using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temparature
{
    public partial class TemparatureUI : Form
    {
        public TemparatureUI()
        {
            InitializeComponent();
        }
        double store = 0.0;
        double celcius = 0.0;
        double fahrenheit = 0.0;
        private void showButton_Click(object sender, EventArgs e)
        {
            if (celciusButton.Checked && fahinputTextBox.Text!="")
            {
                store = Convert.ToDouble(fahinputTextBox.Text);
                celcius=((store-32)/1.8);
                celciusTextBox.Text = celcius.ToString();
            }
            else if (fahrenheitRadioButton.Checked && celinputTextBox.Text!="")
            {
                store = Convert.ToDouble(celinputTextBox.Text);
                fahrenheit =((store*1.8)+32);
                fahrenheitTextBox.Text = fahrenheit.ToString();
            }
            else
                MessageBox.Show(@" :) Choose an option first or check the input text box for proper input");
        }
    }
}

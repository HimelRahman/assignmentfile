using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palindrom
{
    public partial class PalindromcheckUI : Form
    {
        public PalindromcheckUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string name = inputTextBox.Text;
            int length = name.Length-1;
            char [] word = name.ToCharArray();
            int count = 0;
            for (int index = 0; index < length; index += 1, length -= 1)
            {
                if (word[index] != word[length])
                {
                    count = 1;
                    break;
                }
            }
            if (count == 0)
                outputLabel.Text = name + " is palindrom";
            else
                outputLabel.Text = name + " is not palindrom";
        }
    }
}

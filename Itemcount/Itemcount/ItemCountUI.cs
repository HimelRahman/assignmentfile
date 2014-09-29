using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itemcount
{
    public partial class ItemCountUI : Form
    {
        public ItemCountUI()
        {
            InitializeComponent();
        }
        int index = 0;
        List<string> list = new List<string>();

        private void addButton_Click(object sender, EventArgs e)
        {
            list.Add(inputTextBox.Text);
            index += 1;
            inputTextBox.Text = " ";
            countLabe.Text = Convert.ToString(index);
            if (index == 10)
            {
                addButton.Enabled = false;
                outputlistBox.Items.Clear();
                foreach (string name in list)
                {
                    outputlistBox.Items.Add(name);
                }

            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            outputlistBox.Items.Clear();
            addButton.Enabled = true;
            index = 0;
            countLabe.Text = " ";
            list.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputlistBox.Items.Clear();
            if (list.Count == 0)
                MessageBox.Show("Insert item first");
            foreach(string store in list)
                outputlistBox.Items.Add(store);
        }
    }
}

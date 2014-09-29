using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraywith_list
{
    public partial class StudentgradesheetUI : Form
    {
        public StudentgradesheetUI()
        {
            InitializeComponent();
        }

        string roll;
        string ban;
        string eng;
        String math;
        string snc;
        string [,] arr = new string[28,85];
        int row = 0;
        int col = 0;
        int cl = 0;
        private void savebutton_Click(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            roll = rolltextBox.Text;
            ban = banglatextBox.Text;
            eng = englishtextBox.Text;
            math = mathtextBox.Text;
            snc = sciencetextBox.Text;

            rolltextBox.Text =" ";
            banglatextBox.Text =" ";
            englishtextBox.Text = " ";
            mathtextBox.Text = " ";
            sciencetextBox.Text = " ";

            arr[row, col++] = roll;
            arr[row, col++] = ban;
            arr[row, col++] = eng;
            arr[row, col++] = math;
            arr[row, col]= snc;
            cl = col;
            row += 1; col = 0;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id=0,i;
            int j = 0;
            roll = edTextBox.Text;
            MessageBox.Show("roll for edit: " + roll);
            for (id=0;id<row;id+=1)
            {
                if ((roll.Trim()) == (arr[id,0].Trim()))                //Convert.ToInt32(arr[i, 0]) == (Convert.ToInt32(roll))
                {
                    MessageBox.Show(arr[id,0]);
                    break; 
                }
            }
            rolltextBox.Text = arr[id, j++];
            banglatextBox.Text = arr[id, j++];
            englishtextBox.Text = arr[id, j++];
            mathtextBox.Text = arr[id, j++];
            sciencetextBox.Text = arr[id, j++];

            editButton.Enabled = false; 
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            showlistBox.Items.Clear();

            for (int i = 0; i < row; i += 1)
                for (int j = 0; j <= cl; j += 1)
                    showlistBox.Items.Add(arr[i, j]);
        }
    }
}

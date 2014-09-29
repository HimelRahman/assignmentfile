using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace employeesalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string location = @"E:\str\empslry.txt";
        string nam;
        string id;
        string slry;
        string arow;
        private void savebutton_Click(object sender, EventArgs e)
        {
            nam = nametextBox.Text;
            id = idtextBox.Text;
            slry = salarytextBox.Text;

            FileStream afile = new FileStream(location, FileMode.Append);
            StreamWriter writer = new StreamWriter(afile);
            arow = (nam + "," + id + "," + slry);
            writer.Write(arow);
            writer.WriteLine();
            writer.Close();
            clearAll();
            MessageBox.Show("Sucessfully saved information");
        }

        private void clearAll()
        {
            nametextBox.Text = " ";
            idtextBox.Text = " ";
            salarytextBox.Text = " "; 
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            FileStream afle = new FileStream(location, FileMode.Open);
            StreamReader reader = new StreamReader(afle);
            showlistBox.Items.Clear();
            double total = 0.0;
            while(!reader.EndOfStream)
            {
                string aRow = reader.ReadLine();
                char[] seperator = { ',' };
                string[] employeeInfo = aRow.Split(seperator);
                showlistBox.Items.Add(employeeInfo[0] + " " + employeeInfo[1] + " " + employeeInfo[2]);
                double salary = Convert.ToDouble(employeeInfo[2]);
                MessageBox.Show(employeeInfo[2]);
                double salry = Convert.ToDouble(employeeInfo[2]);
                total+=salry;
            }
            amounttextBox.Text = total.ToString();
            reader.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeindecs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> idlist = new List<int>();
        List<string> namlist = new List<string>();
        List<double> sallist = new List<double>();
        List<string> adreslist = new List<string>(); 

        private void savebutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idtextBox.Text);
            string nam =nametextBox.Text;
            double slry = Convert.ToDouble(salarytextBox.Text);
            string adrs = addresstextBox.Text;

            saveemployeinfo(id, nam, slry, adrs);
            insertintolstvew(id, nam, slry);

        }

        private void insertintolstvew(int id, string nam, double slry)
        {
            ListViewItem itm = new ListViewItem();
            itm.Text = id.ToString();
            itm.SubItems.Add(nam);
            itm.SubItems.Add(slry.ToString());
            outputlistView.Items.Add(itm);
        }

        private void saveemployeinfo(int id, string nam, double slry, string adrs)
        {
            idlist.Add(id);
            namlist.Add(nam);
            sallist.Add(slry);
            adreslist.Add(adrs);
        }

        private void outputlistView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectindex = outputlistView.SelectedIndices[0];
            idtextBox.Text = idlist[selectindex].ToString();
            nametextBox.Text = namlist[selectindex];
            salarytextBox.Text = sallist[selectindex].ToString();
            addresstextBox.Text = adreslist[selectindex];
        }
    }
}

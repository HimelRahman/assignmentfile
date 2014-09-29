using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Boisearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string isbn_no;
        string detail;
        Hashtable store = new Hashtable();
        private void addButton_Click(object sender, EventArgs e)
        {
            isbn_no = isbnTextBox.Text;
            detail = detailTextBox.Text;
            store.Add(isbn_no,detail);
            ClearAll();
            MessageBox.Show("Information is saved");
        }

        private void ClearAll()
        {
            isbnTextBox.Text = string.Empty;
             detailTextBox.Text = string.Empty;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            isbn_no = inputTextBox.Text;

            foreach (string srch in store.Keys)
            {
                if (srch==isbn_no)
                {
                    outputTextBox.Text = store[srch].ToString();
                    break;
                }
            }
        }    

    }

       
}

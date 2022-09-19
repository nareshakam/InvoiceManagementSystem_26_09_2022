using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleTire;
using System.Text.RegularExpressions;

namespace InvoiceSystem
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }
        public bool InvoiceNumberCheck(string InvoiceNumber)
        {
            Regex rg = new Regex("^[INV][0-9]{4}$");
            if(rg.IsMatch(InvoiceNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void scearch(string InvoiceNumber)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            DataSet ds = mdc.SearchInvoice(InvoiceNumber);
            dataGridViewscarch.DataSource = ds.Tables[0];
        }

        private void BtnScearch_Click(object sender, EventArgs e)
        {
            string InvoiceNumber = txtInvoiceNumberData.Text;
            scearch(InvoiceNumber);
            txtInvoiceNumberData.Text = "";
            txtNamedata.Text = "";
        }
    }
}

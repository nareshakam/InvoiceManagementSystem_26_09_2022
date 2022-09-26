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
    public partial class KnowingInvoiceNumber : Form
    {
        private static string byway = "name";
        public static string Byway { get => byway; set => byway = value; }

        public KnowingInvoiceNumber()
        {
            InitializeComponent();
        }

        private void BtnScearch_Click(object sender, EventArgs e)
        {
            string CustmerName = txtNameData.Text;
            string exp = "^[a-zA-Z0-9]{1-20}$";
            Regex rx = new Regex(exp);
            lblnameerror.Visible = false;
            string name = txtNameData.Text;
            if (txtNameData.Text.Length==0&&byway.Equals("name"))
            {
                lblnameerror.Visible = true;
                lblnameerror.Text="*please give a proper Name...!";
            }
            else
            {
                fetch(CustmerName);
            }
            
            
        }
        private void fetch(string CustmerName)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            DataSet ds = mdc.getinvoiceNumber(CustmerName);
            dataGridViewInvoicecearch.DataSource = ds.Tables[0];
        }

        private void txtNameData_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void KnowingInvoiceNumber_Load(object sender, EventArgs e)
        {
            if (byway != "name")
            {
                txtNameData.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

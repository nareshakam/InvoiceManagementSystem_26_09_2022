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
        public KnowingInvoiceNumber()
        {
            InitializeComponent();
        }

        private void BtnScearch_Click(object sender, EventArgs e)
        {
            string CustmerName = txtNameData.Text;
            string date = txtdatedata.Text;
            string exp = "^[a-zA-Z]{1-20}$";
            Regex rx = new Regex(exp);
            string name = txtNameData.Text;
            if (rx.IsMatch(name))
            {
                MessageBox.Show("Invalied Name give a proper Name...!");
                return;
            }
            else
            {
                fetch(CustmerName, date);
            }
            
            
        }
        private void fetch(string CustmerName,string date)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            DataSet ds = mdc.getinvoiceNumber(CustmerName, date);
            dataGridViewInvoicecearch.DataSource = ds.Tables[0];
        }

        private void txtNameData_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

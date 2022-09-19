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

namespace InvoiceSystem
{
    public partial class InvoiceForm : Form
    {
        private string _InvoiceNumber = "";
        public string InvoiceNumber
        { 
            get => _InvoiceNumber; 
            set => _InvoiceNumber = value; 
        }

        public InvoiceForm()
        {
            InitializeComponent();
        }

        public void InsertMainCart()
        {
            string invoiceNumber = _InvoiceNumber;
            string InvoiceDate = txtDatedata.Text;
            string CustmerName = txtnameData.Text;
            string status = cmbStatus.SelectedItem.ToString();
            string address = txtAddressData.Text.ToString();

            int a = insertCustmerDetails(invoiceNumber,CustmerName,InvoiceDate,address,status);
            if(a>0)
            {
                MessageBox.Show("Invoice Saved Success fully...!");
            }
            else
            {
                MessageBox.Show("opps! Try Again...!");
            }

        }
        public int insertCustmerDetails(string InvoiceNumber,string Name,string Date,string Address,string status)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            int a = 0;
            try 
            { 
               a = mdc.InsertCustmerDetails(InvoiceNumber,Date,Name,Address,status);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return a;
        }
        public DataSet getcart()
        {
            MidleTireConnection mdc = new MidleTireConnection();
            return mdc.GetCart(_InvoiceNumber);
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            InvoiceNumberDatalb.Text = _InvoiceNumber.ToString();
            lblTotalAmount.Text = mdc.GetTotalInvoice(_InvoiceNumber).ToString();
            DataSet ds = getcart();
            dataGridViewinvoice.DataSource = ds.Tables[0];
        }

        private void dataGridViewinvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            InsertMainCart();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

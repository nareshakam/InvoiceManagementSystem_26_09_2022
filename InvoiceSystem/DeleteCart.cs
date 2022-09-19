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
    public partial class DeleteCart : Form
    {
        private bool isAdmin = false;

        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        public DeleteCart()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string invoiceNumber = txtInvoice.Text;
            

            
            DialogResult Delete;
            try
            {
                Delete = MessageBox.Show("conform if you want to Delete "+invoiceNumber+" Cart", "Invoice manage system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Delete == DialogResult.Yes)
                {
                    MidleTireConnection mdc = new MidleTireConnection();
                    int a = mdc.DeleteCart(invoiceNumber);
                    if (a > 0)
                    {
                        DialogResult DeleteMain;
                        try
                        {
                            DeleteMain = MessageBox.Show("conform if you want to Delete Custmer Details too", "Invoice manage system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (DeleteMain == DialogResult.Yes)
                            {                               
                                mdc.DeleteMianCart(invoiceNumber);
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowData_Click(object sender, EventArgs e)
        {
            string invoiceNumber = txtInvoice.Text;
            cartInformation(invoiceNumber);
            CustmerInformation(invoiceNumber);
        }
        public void cartInformation(string invoiceNumber)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            DataSet ds = mdc.GetCart(invoiceNumber);
            dataGridViewCartInformation.DataSource = ds.Tables[0];
        }
        public void CustmerInformation(string invoicenumber)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            DataSet ds = mdc.MainCart(invoicenumber);
            dataGridViewCustmerInformation.DataSource = ds.Tables[0];
        }
    }
}

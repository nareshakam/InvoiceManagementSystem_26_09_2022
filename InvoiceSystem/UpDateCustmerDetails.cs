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
    public partial class UpDateCustmerDetails : Form
    {
        public UpDateCustmerDetails()
        {
            InitializeComponent();
        }

        private void UpDateCustmerDetails_Load(object sender, EventArgs e)
        {
            mainLoad();
        }

        public void mainLoad()
        {
            MidleTireConnection mdc = new MidleTireConnection();
            DataSet ds = mdc.MainCart();
            dataGridViewMainEdit.DataSource = ds.Tables[0];
        }

        private void dataGridViewMainEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCustmerName.Text = dataGridViewMainEdit.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDateData.Text = dataGridViewMainEdit.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbstatus.SelectedItem = dataGridViewMainEdit.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbInvoiceNumber.Text = dataGridViewMainEdit.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtaddress.Text = dataGridViewMainEdit.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustmerDetails();
        }
        public void UpdateCustmerDetails()
        {
            string invoiceNumber = lbInvoiceNumber.Text;
            string name = txtCustmerName.Text;
            string date = txtDateData.Text;
            string address = txtaddress.Text;
            string status = cmbstatus.SelectedItem.ToString();

            MidleTireConnection mdc = new MidleTireConnection();
            mdc.UpdateMaincart(name,date,address,invoiceNumber,status);
            mainLoad();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string InvoiceNumber = lbInvoiceNumber.Text;
            DialogResult Delete;
            try
            {
                Delete = MessageBox.Show("conform if you want to exit", "billing manage system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Delete == DialogResult.Yes)
                {
                    MidleTireConnection mdc = new MidleTireConnection();
                    mdc.DeleteMianCart(InvoiceNumber);
                    mdc.DeleteCart(InvoiceNumber);
                    mainLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

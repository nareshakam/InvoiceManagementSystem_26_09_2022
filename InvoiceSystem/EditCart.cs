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
    public partial class EditCart : Form
    {
       
        double Bread = 10.20;
        double rice = 18.50;
        double suger = 15.50;
        double beans = 25.60;
        double milk = 69.75;

        public EditCart()
        {
            InitializeComponent();
        }
        public void cartInformation(string invoiceNumber)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            DataSet ds = mdc.GetCart(invoiceNumber);
            dataGridViewedit.DataSource = ds.Tables[0];
        }

        private void BtnShowData_Click(object sender, EventArgs e)
        {
            string invoiceNumber = txtIInvoicenumber.Text;
            cartInformation(invoiceNumber);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pname = lbProductname.Text;
            int pq = Convert.ToInt32(cmdpq.SelectedItem);
            if (pname.Equals("Bread"))
            {
                lbproductPrice.Text = Convert.ToString(pq * Bread);
            }
            if (pname.Equals("Rice"))
            {
                lbproductPrice.Text = Convert.ToString(pq * rice);
            }
            if (pname.Equals("Milk"))
            {
                lbproductPrice.Text = Convert.ToString(pq * milk);
            }
            if (pname.Equals("Suger"))
            {
                lbproductPrice.Text = Convert.ToString(pq * suger);
            }
            if (pname.Equals("Beans"))
            {
                lbproductPrice.Text = Convert.ToString(pq * beans);
            }
        }

        private void EditCart_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewedit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void dataGridViewedit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            //int strSelectedCustmer = Convert.ToInt32(datagridviewRedlt.Rows[e.RowIndex].Cells[0].Value);
            string pname = dataGridViewedit.Rows[e.RowIndex].Cells[0].Value.ToString();
            double pprice = Convert.ToDouble(dataGridViewedit.Rows[e.RowIndex].Cells[2].Value.ToString().ToString());
            int pquantity = Convert.ToInt32(dataGridViewedit.Rows[e.RowIndex].Cells[1].Value.ToString().ToString());
            lbProductname.Text = pname;
            cmdpq.SelectedItem = pquantity;
            if(pname.Equals("Bread"))
            {
                lbproductPrice.Text = Convert.ToString(pquantity * Bread);
            }
            if (pname.Equals("Rice"))
            {
                lbproductPrice.Text = Convert.ToString(pquantity * rice);
            }
            if (pname.Equals("Milk"))
            {
                lbproductPrice.Text = Convert.ToString(pquantity * milk);
            }
            if (pname.Equals("Suger"))
            {
                lbproductPrice.Text = Convert.ToString(pquantity * suger);
            }
            if (pname.Equals("Beans"))
            {
                lbproductPrice.Text = Convert.ToString(pquantity * beans);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string pname = lbProductname.Text;
            int pq = Convert.ToInt32(cmdpq.SelectedItem);
            double pprice = Convert.ToDouble(lbproductPrice.Text);
            string IvNumber = txtIInvoicenumber.Text;

            Updateitems(pname, pq, pprice, IvNumber);
            cartInformation(IvNumber);
        }
        public void Updateitems(string pname,int pq,double pprice,string InNumber)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            mdc.UpdateItems(pname, pq, pprice, InNumber);
        }
    }
}

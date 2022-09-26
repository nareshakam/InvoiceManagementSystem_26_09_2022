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
    public partial class Form1 : Form
    {
        double Bread = 10.20;
        double rice = 18.50;
        double suger = 15.50;
        double beans = 25.60;
        double milk = 69.75;

        string InvoiceNumber = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            NumBread.Value = 0;
            NumRice.Value = 0;
            NumBeans.Value = 0;
            NumSuger.Value = 0;
            NumMilk.Value = 0;

            rtReceipt.Clear();

            lblBeansAmount.Text = "Rs.0.00";
            lblSugerAmount.Text = "Rs.0.00";
            lblBreadAmmount.Text = "Rs.0.00";
            lblMilkAmount.Text = "Rs.0.00";
            lblRiceAmount.Text = "Rs.0.00";
            lblTotalQuantity.Text = "0";
            lblTotalAmount.Text = "Rs.0.00";
        }
        private void NumBread_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(NumBread.Value);
            lblBreadAmmount.Text =(i * Bread).ToString();
        }
        private void NumRice_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(NumRice.Value);
            lblRiceAmount.Text = (i * rice).ToString();
        }
        private void NumBeans_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(NumBeans.Value);
            lblBeansAmount.Text = (i * beans).ToString();
        }
        private void NumSuger_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(NumSuger.Value);
            lblSugerAmount.Text = (i * suger).ToString();
        }
        private void NumMilk_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(NumMilk.Value);
            lblMilkAmount.Text = (i * milk).ToString();
        }
        private void BtnTotal_Click(object sender, EventArgs e)
        {
            double[] q = new double[7];

            q[0] = Convert.ToDouble(NumBread.Value);
            q[1] = Convert.ToDouble(NumBeans.Value);
            q[2] = Convert.ToDouble(NumMilk.Value);
            q[3] = Convert.ToDouble(NumSuger.Value);
            q[4] = Convert.ToDouble(NumRice.Value);

            q[5] = q[0] + q[1] + q[2] + q[3] + q[4];

            lblTotalQuantity.Text = q[5].ToString();

            double[] items = new double[7];
            items[0] = q[0] * Bread;
            items[1] = q[1] * beans;
            items[2] = q[2] * milk;
            items[3] = q[3] * suger;
            items[4] = q[4] * rice;
            items[5] = items[0] + items[1] + items[2] + items[3] + items[4];
            lblTotalAmount.Text = Convert.ToString(items[5]);
        }
        private void BtnRecipt_Click(object sender, EventArgs e)
        {
            rtReceipt.Clear();
            Font = new Font(rtReceipt.Font, FontStyle.Bold);

            rtReceipt.AppendText("------  Bakery Invoice Management System ----"+"\n" + "\n");

            rtReceipt.AppendText("--"+itemslbl.Text+"--"+"\t"+ "\t" +"    "+ "--" + noofitemslbl.Text+ "--" + "\t" + "    "+ "--" + costofitemlbl.Text+"(in rs.)"+ "--" + "\n" +"\n");
            rtReceipt.AppendText("  "+LBread.Text + "\t" + "\t"+ "\t" + NumBread.Value + "\t" + "\t" + "     " + lblBreadAmmount.Text + "\n" + "\n");
            rtReceipt.AppendText("  " + lbBeans.Text + "\t" + "\t" + "\t" + NumBeans.Value + "\t" + "\t" + "     " + lblBeansAmount.Text + "\n" + "\n");
            rtReceipt.AppendText("  " + lbMilk.Text + "\t" + "\t" + "\t" + NumMilk.Value + "\t" + "\t" + "     " + lblMilkAmount.Text + "\n" + "\n");
            rtReceipt.AppendText("  " + lbSuger.Text + "\t" + "\t" + "\t" + NumSuger.Value + "\t" + "\t" + "     " + lblSugerAmount.Text + "\n" + "\n");
            rtReceipt.AppendText("  " + lbRice.Text + "\t" + "\t" + "\t" + NumRice.Value + "\t" + "\t" + "     " + lblRiceAmount.Text + "\n" + "\n");
            rtReceipt.AppendText("  " + lbTotal.Text + "\t" + "\t" + "\t" + lblTotalQuantity.Text + "\t" + "\t" + "     " + lblTotalAmount.Text + "\n" + "\n");
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Manage System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                System.Drawing.Font sdf = new System.Drawing.Font("Arial",18,FontStyle.Regular);
                e.Graphics.DrawString(rtReceipt.Text, sdf, Brushes.Black, 120, 120);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Manage System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string GenerateID()
        {
            string numbers = "1234567890";

            string characters = numbers;
            int length = 4;
            string id = string.Empty;
            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                }
                while (id.IndexOf(character) != -1);
                id += character;
            }
            string InvoiceNumber = "INV" + id;
            return InvoiceNumber;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void rtReceipt_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void insertItems()
        {
            MidleTireConnection mdc = new MidleTireConnection();
            InvoiceNumber = mdc.GenerateId();
            if (true)
            {
                string pname = LBread.Text;
                int pq = Convert.ToInt32(NumBread.Value);
                double pprice = Convert.ToDouble(lblBreadAmmount.Text);
                mdc.InsertItems(pname,pq,pprice,InvoiceNumber);
            }
            if(true)
            {
                string pname = lbBeans.Text;
                int pq = Convert.ToInt32(NumBeans.Value);
                double pprice = Convert.ToDouble(lblBeansAmount.Text);
                mdc.InsertItems(pname, pq, pprice, InvoiceNumber);
            }
            if (true)
            {
                string pname = lbRice.Text;
                int pq = Convert.ToInt32(NumRice.Value);
                double pprice = Convert.ToDouble(lblRiceAmount.Text);
                mdc.InsertItems(pname, pq, pprice, InvoiceNumber);
            }
            if (true)
            {
                string pname = lbMilk.Text;
                int pq = Convert.ToInt32(NumMilk.Value);
                double pprice = Convert.ToDouble(lblMilkAmount.Text);
                mdc.InsertItems(pname, pq, pprice, InvoiceNumber);
            }
            if (true)
            {
                string pname = lbSuger.Text;
                int pq = Convert.ToInt32(NumSuger.Value);
                double pprice = Convert.ToDouble(lblSugerAmount.Text);
                mdc.InsertItems(pname, pq, pprice, InvoiceNumber);
            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult iexit;
            try
            {
                iexit = MessageBox.Show("conform if you want to exit", "billing manage system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iexit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            insertItems();
            InvoiceForm inf = new InvoiceForm();
            inf.InvoiceNumber = InvoiceNumber;
            inf.ShowDialog();
            this.Close();
        }
    }
}

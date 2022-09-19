using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceMainDemo
{
    public partial class EditCart : System.Web.UI.Page
    {
        private static string _InvoiceNumberedit = "";
        public string InvoiceNumber1 { get => _InvoiceNumberedit; set => _InvoiceNumberedit = value; }
        double Bread = 10.20;
        double rice = 18.50;
        double suger = 10.20;
        double beans = 10.20;
        double milk = 10.20;
        double[] q = new double[7];
        double[] items = new double[7];

        protected void Page_Load(object sender, EventArgs e)
        {
            //Display();
            lblInvoiceNumberdata.Text = _InvoiceNumberedit;
        }
        //public void Display()
        //{
        //    DataTable dt = ItemsDisplay();
        //    foreach(DataRow dr in dt.Rows)
        //    {
        //        string pn = dr["ProductName"].ToString();
        //        int pq = Convert.ToInt32(dr["ProductQuantity"]);
        //        double pa = Convert.ToDouble(dr["ProductPrice"]);
        //        if(pn=="Bread")
        //        {
        //            ddlBread.SelectedValue = pq.ToString();
        //            lbBreadAmount.Text = pa.ToString();
        //        }
        //        if (pn == "Rice")
        //        {
        //            ddlBread.SelectedValue = pq.ToString();
        //            lbBreadAmount.Text = pa.ToString();
        //        }
        //        if (pn == "Beans")
        //        {
        //            ddlBread.SelectedValue = pq.ToString();
        //            lbBreadAmount.Text = pa.ToString();
        //        }
        //        if (pn == "Suger")
        //        {
        //            ddlBread.SelectedValue = pq.ToString();
        //            lbBreadAmount.Text = pa.ToString();
        //        }
        //        if (pn == "Milk")
        //        {
        //            ddlBread.SelectedValue = pq.ToString();
        //            lbBreadAmount.Text = pa.ToString();
        //        }
        //    }
        protected void ddlBread_SelectedIndexChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(ddlBread.SelectedValue);
            lbBreadAmount.Text = Convert.ToString(Bread * i);
        }

        protected void ddlRice_SelectedIndexChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(ddlRice.SelectedValue);
            lbRiceAmount.Text = Convert.ToString(rice * i);
        }

        protected void ddlbeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(ddlbeans.SelectedValue);
            lbBeansAmount.Text = Convert.ToString(beans * i);
        }

        protected void ddlRice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(ddlsuger.SelectedValue);
            lbSugerAmount.Text = Convert.ToString(suger * i);
        }

        protected void ddlmilk_SelectedIndexChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(ddlmilk.SelectedValue);
            lbMilkAmount.Text = Convert.ToString(milk * i);
        }
        protected void BtnTotal_Click(object sender, EventArgs e)
        {

            q[0] = Convert.ToDouble(ddlRice.SelectedValue);
            q[1] = Convert.ToDouble(ddlsuger.SelectedValue);
            q[2] = Convert.ToDouble(ddlbeans.SelectedValue);
            q[3] = Convert.ToDouble(ddlmilk.SelectedValue);
            q[4] = Convert.ToDouble(ddlBread.SelectedValue);
            q[5] = q[0] + q[1] + q[2] + q[3] + q[4];
            lbTotatlQuantity.Text = q[5].ToString();


            items[0] = Convert.ToDouble(lbRiceAmount.Text);
            items[1] = Convert.ToDouble(lbSugerAmount.Text);
            items[2] = Convert.ToDouble(lbBeansAmount.Text);
            items[3] = Convert.ToDouble(lbMilkAmount.Text);
            items[4] = Convert.ToDouble(lbBreadAmount.Text);
            items[5] = items[0] + items[1] + items[2] + items[3] + items[4];
            lbTotalAmount.Text = items[5].ToString();
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            ddlbeans.SelectedIndex = 0;
            ddlBread.SelectedIndex = 0;
            ddlmilk.SelectedIndex = 0;
            ddlRice.SelectedIndex = 0;
            ddlsuger.SelectedIndex = 0;
            lbTotalAmount.Text = "0";
            lbTotatlQuantity.Text = "0";
            lbRiceAmount.Text = "0";
            lbSugerAmount.Text = "0";
            lbMilkAmount.Text = "0";
            lbBreadAmount.Text = "0";
            lbBeansAmount.Text = "0";

        }
        public void Insertitems(string pname, int pquantity, double pprice, string InvoiceNumber)
        {
            string ConnectingString = "Data Source=IN-WIN-NAKKAM\\SQLEXPRESS;Initial Catalog=BakeryStore;User ID=sa;Password=12345;Pooling=False";
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();
            string query = "INSERT INTO InvoiceCart VALUES('" + pname + "'," + pquantity + "," + pprice + ",'" + InvoiceNumber + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void selecteditems()
        {
            string InvoiceNumber = _InvoiceNumberedit;
            Invoice inv = new Invoice();
            inv.InvoiceNumber1 = InvoiceNumber;
            if (ddlBread.SelectedValue != "0")
            {
                string pName = breadlb.Text;
                int pQuantity = Convert.ToInt32(ddlBread.SelectedValue);
                double ptotalPrice = Convert.ToDouble(lbBreadAmount.Text);
                Insertitems(pName, pQuantity, ptotalPrice, InvoiceNumber);
            }
            if (ddlRice.SelectedValue != "0")
            {
                string pName = Ricelb.Text;
                int pQuantity = Convert.ToInt32(ddlRice.SelectedValue);
                double ptotalPrice = Convert.ToDouble(lbRiceAmount.Text);
                Insertitems(pName, pQuantity, ptotalPrice, InvoiceNumber);

            }
            if (ddlbeans.SelectedValue != "0")
            {
                string pName = Beanslb.Text;
                int pQuantity = Convert.ToInt32(q[2]);
                double ptotalPrice = Convert.ToDouble(lbBeansAmount.Text);

                Insertitems(pName, pQuantity, ptotalPrice, InvoiceNumber);
            }
            if (ddlsuger.SelectedValue != "0")
            {
                string pName = sugerlb.Text;
                int pQuantity = Convert.ToInt32(ddlsuger.SelectedValue);
                double ptotalPrice = Convert.ToDouble(lbSugerAmount.Text);
                Insertitems(pName, pQuantity, ptotalPrice, InvoiceNumber);

            }
            if (ddlmilk.SelectedValue != "0")
            {
                string pName = Milklb.Text;
                int pQuantity = Convert.ToInt32(ddlmilk.SelectedValue);
                double ptotalPrice = Convert.ToDouble(lbMilkAmount.Text);
                Insertitems(pName, pQuantity, ptotalPrice, InvoiceNumber);
            }
        }
        public void DeleteItems()
        {
            string ConnectingString = "Data Source=IN-WIN-NAKKAM\\SQLEXPRESS;Initial Catalog=BakeryStore;User ID=sa;Password=12345;Pooling=False";
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();
            string query = "DELETE FROM InvoiceCart Where InvoiceNumber ='" + _InvoiceNumberedit + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
        }
        protected void BtnPaynow_Click(object sender, EventArgs e)
        {
            DeleteItems();
            selecteditems();
            Response.Redirect("upiPaymentVerification.aspx");
        }
        //private DataTable ItemsDisplay()
        //{
        //    string ConnectingString = "Data Source=IN-WIN-NAKKAM\\SQLEXPRESS;Initial Catalog=BakeryStore;User ID=sa;Password=12345;Pooling=False";
        //    SqlConnection conn = new SqlConnection(ConnectingString);
        //    conn.Open();
        //    string query = "SELECT * FROM InvoiceCart Where InvoiceNumber = '"+_InvoiceNumberedit+"'";
        //    SqlCommand cmd = new SqlCommand(query,conn);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    return dt;
        //}
    }
}
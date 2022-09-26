using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DataConnect;
using MiddleTire;

namespace InvoiceMainDemo
{
    public partial class InvoceSearch : System.Web.UI.Page
    {
        private static bool isAdmin = false;
        
        double Bread = 10.20;
        double rice = 18.50;
        double suger = 15.50;
        double beans = 25.60;
        double milk = 69.75;

        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProductName = GridViewcardDetails.SelectedRow.Cells[1].Text;
            int quantity = Convert.ToInt32(GridViewcardDetails.SelectedRow.Cells[2].Text);
            double price = Convert.ToDouble(GridViewcardDetails.SelectedRow.Cells[3].Text);

            display(ProductName, quantity, price);
        }

        public void display(string Name,int quantity,double price)
        {
            lblNameData.Text = Name;
            ddlpquantity.SelectedValue = quantity.ToString();
            lblPriceData.Text = price.ToString();
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            if (status())
            {
                lbltotalAmount.Visible = true;
                lbltotalAmount.Text = System.Drawing.Color.Green.ToString();
                lbltotalAmount.Text="Alredy Paid...!";
            }
            else
            {
                LoadItemsScarch();
            }
        }

        public void LoadItemsScarch()
        {
            GridViewcardDetails.DataSource = SearchInvoice();
            GridViewcardDetails.DataBind();
        }

        public bool status()
        { 
            string InvoiceNumber = txtInvoiceNumberData.Text;
            MidleTireConnection mdc = new MidleTireConnection();
            return mdc.Status(InvoiceNumber);
        }

        public DataSet  SearchInvoice()
        {
            string InvoiceNumber = txtInvoiceNumberData.Text;
            MidleTireConnection mdc = new MidleTireConnection();
            DataSet ds = mdc.SearchInvoice(InvoiceNumber);
            return ds;
        }

        protected void ddlpquantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lblNameData.Text;
            if(name=="Bread")
            {
                lblPriceData.Text =Convert.ToString(Convert.ToInt32(ddlpquantity.SelectedValue) * Bread);
            }
            if (name == "Beans")
            {
                lblPriceData.Text = Convert.ToString(Convert.ToInt32(ddlpquantity.SelectedValue) * beans);
            }
            if (name == "Suger")
            {
                lblPriceData.Text = Convert.ToString(Convert.ToInt32(ddlpquantity.SelectedValue) * suger);
            }
            if (name == "Milk")
            {
                lblPriceData.Text = Convert.ToString(Convert.ToInt32(ddlpquantity.SelectedValue) * milk);
            }
            if (name == "Rice")
            {
                lblPriceData.Text = Convert.ToString(Convert.ToInt32(ddlpquantity.SelectedValue) * rice);
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string pname = lblNameData.Text;
                int pquantity = Convert.ToInt32(ddlpquantity.SelectedValue);
                double price = Convert.ToDouble(lblPriceData.Text);
                string InvoiceNumber = txtInvoiceNumberData.Text;
                UpDateItems(pname, pquantity, price, InvoiceNumber);
                LoadItemsScarch();
                lblNameData.Text = "";
                ddlpquantity.SelectedIndex = 0;
                lblPriceData.Text = "";
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        public void UpDateItems(string pName,int pquantity,double pprice,string InvoiceNumber)
        {
            
                //1.sql connection
                String ConnectionString = "Data Source=IN-WIN-NAKKAM\\SQLEXPRESS;Initial Catalog=BakeryStore;User ID=sa;Password=12345;Pooling=False";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
            try
            {
                //2.fire the Command object
                //Stroed Procedures
                string query = "UPDATE InvoiceCart SET ProductQuantity = " + pquantity + ", ProductPrice =" + pprice + " WHERE InvoiceNumber = '" + InvoiceNumber + "' AND ProductName = '" + pName + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    Response.Write("Updated Successfully..!");
                }
                else
                {
                    Response.Write("Updated Faild..!");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                //Close the connection
                conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(isAdmin)
            {
                Response.Redirect("InvoiceHome.aspx");
            }
            else
            {
                Response.Redirect("SelectItems.aspx");
            }
        }
    }
}
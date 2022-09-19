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
    public partial class Invoice : System.Web.UI.Page
    {
        private bool isAdmin = false;
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        private static string _InvoiceStatus = "";
        private static string _InvoiceNumber = "";
        public string InvoiceNumber1 { get => _InvoiceNumber; set => _InvoiceNumber = value; }
        public string InvoiceStatus1 { get => _InvoiceStatus; set => _InvoiceStatus = value; }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            LblInvoiceNumberResult.Text = _InvoiceNumber;
            ddlPaidStatus.SelectedValue = _InvoiceStatus;
            lblInvoiceAmountResult.Text = GetTotalInvoice().ToString();
            LoadCustmer();
        }
        
        public int InsertCustmerDetails()
        {
            string custmerName = txtNameData.Text;
            string address = txtAdressData.Text;
            string date = TxtDateData.Text; 
            string paidStatus = ddlPaidStatus.SelectedValue;
            string InvoiceNumber = LblInvoiceNumberResult.Text;
            int a = 0;
            MidleTireConnection mdc = new MidleTireConnection();
            try
            {
                a = mdc.InsertCustmerDetails(InvoiceNumber, date, custmerName, address, paidStatus);
                return a;
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
                return a;
            }
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            int a =InsertCustmerDetails();
            if (a > 0)
            {
                Response.Write("Invoice Save SucessFully...!");
            }
        }
        public int gettingMaxId()
        {
            MidleTireConnection mdc = new MidleTireConnection();
            return mdc.gettingMaxId();
        }

        public DataSet GetCart()
        {
            MidleTireConnection mdc = new MidleTireConnection();
            return mdc.GetCart(_InvoiceNumber);
        }
        public double GetTotalInvoice()
        {
            MidleTireConnection mdc = new MidleTireConnection();
            return mdc.GetTotalInvoice(_InvoiceNumber);
        }
        private void LoadCustmer()
        {
            GridView1.DataSource = GetCart();
            GridView1.DataBind();
        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                Response.Redirect("InvoiceHome.aspx");
            }
            else
            {
                Response.Redirect("SelectItems.aspx");
            }
        }

        protected void TxtDateData_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class upiPaymentVerification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPaymentRecived_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.InvoiceStatus1 = "Paid";
            Response.Redirect("Invoice.aspx");
        }
        public void DeleteCart(string InvoiceNumber)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            mdc.DeleteCart(InvoiceNumber);
        }
        
        protected void BtnPaymentFaild_Click(object sender, EventArgs e)
        { 
            Invoice inv = new Invoice();
            inv.InvoiceStatus1 = "UnPaid";
            Response.Redirect("Invoice.aspx");
        }
    }
}
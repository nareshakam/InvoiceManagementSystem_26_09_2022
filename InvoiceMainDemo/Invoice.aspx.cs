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
using System.IO;
using System.Web.UI.HtmlControls;

namespace InvoiceMainDemo
{
    public partial class Invoice : System.Web.UI.Page
    {
        private static bool isAdmin = false;
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
                lblmessage.Visible = true;
                lblmessage.ForeColor = System.Drawing.Color.Yellow;
                lblmessage.Text = ex.Message;
                return a;
            }
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            int a =InsertCustmerDetails();
            if (a > 0)
            {
                lblmessage.Visible = true;
                lblmessage.Text = "Invoice Save SucessFully...!";
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

        protected void ddlPaidStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Btnprint_Click(object sender, EventArgs e)
        {

        }
    }
    public class PrintHelper
    {
        public PrintHelper()
        {
        }

        public static void PrintWebControl(Control ctrl)
        {
            PrintWebControl(ctrl, string.Empty);
        }

        public static void PrintWebControl(Control ctrl, string Script)
        {
            StringWriter stringWrite = new StringWriter();
            System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
            if (ctrl is WebControl)
            {
                Unit w = new Unit(100, UnitType.Percentage); ((WebControl)ctrl).Width = w;
            }
            Page pg = new Page();
            pg.EnableEventValidation = false;
            if (Script != string.Empty)
            {
                pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScript", Script);
            }
            HtmlForm frm = new HtmlForm();
            pg.Controls.Add(frm);
            frm.Attributes.Add("runat", "server");
            frm.Controls.Add(ctrl);
            pg.DesignerInitialize();
            pg.RenderControl(htmlWrite);
            string strHTML = stringWrite.ToString();
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Write(strHTML);
            HttpContext.Current.Response.Write("<script>window.print();</script>");
            HttpContext.Current.Response.End();
        }
    }
}
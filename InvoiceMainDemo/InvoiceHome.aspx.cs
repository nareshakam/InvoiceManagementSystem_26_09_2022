using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataConnect;
using System.Data;
using MiddleTire;

namespace InvoiceMainDemo
{
    public partial class InvoiceHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            LoadMaincart();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InvoceSearch.aspx");
        }

        protected void BtnBuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectItems.aspx");
        }

        protected void GridViewMainInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblnameerror.Visible = false;
            lblmessage.Visible = false;
            string name = GridViewMainInvoice.SelectedRow.Cells[3].Text;
            string address = GridViewMainInvoice.SelectedRow.Cells[4].Text;
            string InvoiceNumber = GridViewMainInvoice.SelectedRow.Cells[1].Text;
            string status = GridViewMainInvoice.SelectedRow.Cells[5].Text;
            string date = GridViewMainInvoice.SelectedRow.Cells[2].Text;
            txtInviceNumberData.Enabled = false;
            
            Display(name, address, InvoiceNumber, status, date);
        }
        public void Display(string name,string address,string InvoiceNumber,string status,string date)
        {
            txtnamedata.Text = name;
            txtDatedata.Text = date;
            if (address.Equals("&nbsp;"))
            {
                txtAdressData.Text = "";
            }
            else
            {
                txtAdressData.Text = address;
            }
            txtInviceNumberData.Text = InvoiceNumber;
            ddlStatus.SelectedValue = status;
            lblTotal.Enabled = true;
            lbTotalResult.Enabled = true;
            MidleTireConnection mdc = new MidleTireConnection();
            lbTotalResult.Text = mdc.GetTotalInvoice(InvoiceNumber).ToString();
        }
        public void LoadMaincart()
        {
            MidleTireConnection mdc = new MidleTireConnection();
            GridViewMainInvoice.DataSource = mdc.MainCart();
            GridViewMainInvoice.DataBind();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            lblnameerror.Visible = false;
            lblmessage.Visible = false;
            MidleTireConnection mdc = new MidleTireConnection();
            string InvoiceNumber = txtInviceNumberData.Text;
            int a = mdc.DeleteMianCart(InvoiceNumber);
            int b = mdc.DeleteCart(InvoiceNumber);
            if(a>0&&b>0)
            {
                lblmessage.Visible = true;
                lblmessage.Text = "*Invoice Details Deleted successFully...!";
                LoadMaincart();
            }
            else if(a>0&&b==0)
            {
                lblmessage.Visible = true;
                lblmessage.Text="*Only MianCart Deleted...!";
                LoadMaincart();
            }
            else if(a==0&&b>0)
            {
                lblmessage.Visible = true;
                lblmessage.Text = "*Only InvoiceCart deleted...!";
                LoadMaincart();
            }
            else
            {
                lblmessage.Visible = true;
                lblmessage.Text = "*Delete UnSuccessfull...!";
                LoadMaincart();
            }
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            lblnameerror.Visible = false;
            lblmessage.Visible = false;
            string name = txtnamedata.Text;
            string date = txtDatedata.Text;
            string adress = txtAdressData.Text;
            string InvoiceNumber = txtInviceNumberData.Text;
            string PaidStatus = ddlStatus.SelectedValue;

            int a = UpdateMaincart(name,date,adress,InvoiceNumber,PaidStatus);
            if(a>0)
            {
                lblnameerror.Visible = false;
                lblmessage.Visible = true;
                lblmessage.Text = "*Updated Sucessfully...!";
                cleardata();
            }
            LoadMaincart();
        }
        public int UpdateMaincart(string name,string date,string adress,string Invoicenumber,string PaidStatus)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            return mdc.UpdateMaincart(name, date, adress, Invoicenumber, PaidStatus);
        }
        public void cleardata()
        {
            txtAdressData.Text = "";
            txtDatedata.Text = "";
            txtInviceNumberData.Text = "";
            txtnamedata.Text = "";
            ddlStatus.SelectedIndex = 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtnamedata.Text;
            try
            {
                if (name.Length == 0)
                {
                    GridViewScearchInvoiceNumber.Visible = false;
                    throw new Exception("*please Enter the name in name colum...!");
                }
                else
                {
                    MidleTireConnection mdc = new MidleTireConnection();
                    DataSet ds = mdc.getinvoiceNumber((txtnamedata.Text));
                    GridViewScearchInvoiceNumber.DataSource = ds.Tables[0];
                    GridViewScearchInvoiceNumber.DataBind();
                }
            }
            catch(Exception ex)
            {
                lblnameerror.Visible = false;
                lblnameerror.Visible = true;
                lblnameerror.Text = ex.Message;

            }
            
        }

        protected void GridViewScearchInvoiceNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = GridViewScearchInvoiceNumber.SelectedRow.Cells[3].Text;
            string address = GridViewScearchInvoiceNumber.SelectedRow.Cells[4].Text;
            string InvoiceNumber = GridViewScearchInvoiceNumber.SelectedRow.Cells[1].Text;
            string status = GridViewScearchInvoiceNumber.SelectedRow.Cells[5].Text;
            string date = GridViewScearchInvoiceNumber.SelectedRow.Cells[2].Text;
            txtInviceNumberData.Enabled = false;
            lblnameerror.Visible = false;


            Display(name, address, InvoiceNumber, status, date);
        }

        protected void Btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void txtDatedata_TextChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
            lblnameerror.Visible = false;
        }

        protected void txtInviceNumberData_TextChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
            lblnameerror.Visible = false;
        }

        protected void txtnamedata_TextChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
            lblnameerror.Visible = false;
        }

        protected void txtAdressData_TextChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
            lblnameerror.Visible = false;
        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
            lblnameerror.Visible = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MiddleTire;

namespace InvoiceMainDemo
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private bool isAdmin = false;

        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MidleTireConnection mdc = new MidleTireConnection();
            string userName = txtUserName.Text;
            string Password = txtPassword.Text;
            bool isadmin = mdc.IsAdmin(userName,Password);
            Invoice inv = new Invoice();
            inv.IsAdmin = isadmin;
            InvoceSearch invs = new InvoceSearch();
            invs.IsAdmin = isadmin;
            SelectItems si = new SelectItems();
            si.IsAdmin = isadmin;
            bool valied = mdc.valied(userName, Password);
            if(valied&&isadmin)
            {
                Response.Redirect("InvoiceHome.aspx");
            }
            else if(valied&&!isadmin)
            {

                Response.Redirect("SelectItems.aspx"); ;
            }
            else if(txtUserName.Text.Length==0||txtPassword.Text.Length==0)
            {
                lblerrormessage.Visible = true;
                lblerrormessage.Text = "*please Enter user name/password...!";
            }
            else
            {
                lblerrormessage.Visible = true;
                lblerrormessage.Text = "*Invalied UserName/Password...!";
            }
        }
    }
}
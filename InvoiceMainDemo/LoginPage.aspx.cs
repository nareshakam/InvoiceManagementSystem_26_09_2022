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
            if(mdc.valied(userName,Password)&&isadmin)
            {
                Response.Redirect("InvoiceHome.aspx");
            }
            else if(mdc.valied(userName,Password))
            {

                Response.Redirect("SelectItems.aspx"); ;
            }
            else
            {
                Response.Write("Invalied UserName And Password....!");
            }
        }
    }
}
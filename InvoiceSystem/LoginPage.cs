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
    public partial class LoginPage : Form
    {
        private static int singout = 0;

        public int Singout { get => singout; set => singout = value; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtPasswordData.UseSystemPasswordChar = true;
        }
        public bool userChecking()
        {
            string username = txtUserNameData.Text;
            string password = txtPasswordData.Text;

            MidleTireConnection mdc = new MidleTireConnection();
            return mdc.valied(username,password);
        }
        public bool IsAdmin()
        {
            string username = txtUserNameData.Text;
            string password = txtPasswordData.Text;

            MidleTireConnection mdc = new MidleTireConnection();
            return mdc.IsAdmin(username, password);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            singout = 0;
            MDIInvoice md = new MDIInvoice();
            DeleteCart dc = new DeleteCart();
            dc.IsAdmin = IsAdmin();
            md.IsAdmin = IsAdmin();
            lblErrorMessage.Visible = false;
            lblpassworderror.Visible = false;
            lblUsernameerror.Visible = false;
            if (userChecking())
            {
                LoginPage lp = new LoginPage();
                txtUserNameData.Text = "";
                txtPasswordData.Text = "";
                md.ShowDialog();
                if(singout!=0)
                {
                    
                }
                else
                {
                    this.Close();
                }
            }
            else if(txtUserNameData.Text.Length == 0)
            {
                lblUsernameerror.Visible = true;
                lblUsernameerror.Text = "*Please enter username...!";
            }
            else if (txtPasswordData.Text.Length == 0)
            {
                lblpassworderror.Visible = true;
                lblpassworderror.Text = "*Please Enter password...!";
            }
            else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "*Invalied UserName/Password...!";
            }
        }

        private void txtUserNameData_TextChanged(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            lblpassworderror.Visible = false;
            lblUsernameerror.Visible = false;
        }

        private void txtPasswordData_TextChanged(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            lblpassworderror.Visible = false;
            lblUsernameerror.Visible = false;
        }

        private void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPass.Checked)
            {
                txtPasswordData.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordData.UseSystemPasswordChar = true;
            }
        }
    }
}

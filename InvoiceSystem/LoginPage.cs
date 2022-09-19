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
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
           
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
            MDIInvoice md = new MDIInvoice();
            DeleteCart dc = new DeleteCart();
            dc.IsAdmin = IsAdmin();
            md.IsAdmin = IsAdmin();
            md.ShowDialog();
        }
    }
}

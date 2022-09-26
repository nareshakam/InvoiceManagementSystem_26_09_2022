using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnect;
using System.Data;
using System.Data.SqlClient;

namespace MiddleTire
{
    public class MidleTireConnection
    {
        public void InsertItems(string pname, int pquantity, double pprice, string InvoiceNumber)
        {
            clSqlConnection css = new clSqlConnection();
            css.InsertItems(pname, pquantity, pprice, InvoiceNumber);
        }
        public bool Status(string InvoiceNumber)
        {
            clSqlConnection css = new clSqlConnection();
            return css.Status(InvoiceNumber);
        }
        public DataSet SearchInvoice(string InvoiceNumber)
        {
            clSqlConnection css = new clSqlConnection();
            DataSet ds = css.ScearchInvoice(InvoiceNumber);
            return ds;
        }
        public int DeleteCart(string InvoiceNumber)
        {
            clSqlConnection css = new clSqlConnection();
            return css.DeleteCart(InvoiceNumber);
        }
        public int DeleteMianCart(string InvoiceNumber)
        {
            clSqlConnection css = new clSqlConnection();
            return css.DeleteMainCart(InvoiceNumber);
        }
        public int gettingMaxId()
        {
            clSqlConnection css = new clSqlConnection();
            return css.maxId();
        }
        public DataSet GetCart(string InvoiceNumber)
        {
            clSqlConnection css = new clSqlConnection();
            DataSet ds = css.getCart(InvoiceNumber);
            return ds;
        }
        public double GetTotalInvoice(string InvoiceNumber)
        {
            clSqlConnection css = new clSqlConnection();
            double amount = css.getTotalAmount(InvoiceNumber);
            return amount;
        }
        public int InsertCustmerDetails(string InvoiceNumber,string date,string custmerName,string address,string paidStatus)
        {
            clSqlConnection css = new clSqlConnection();
            int a = css.InsertCustmerDetails(InvoiceNumber, date, custmerName, address, paidStatus);
            return a;
        }
        public DataSet MainCart()
        {
            clSqlConnection css = new clSqlConnection();
            DataSet ds = css.MainCart();
            return ds;
        }
        public DataSet MainCart(string invoicenumber)
        {
            clSqlConnection css = new clSqlConnection();
            DataSet ds = css.MainCart(invoicenumber);
            return ds;
        }
        public int UpdateMaincart(string name,string  date,string address,string InvoiceNumber,string status)
        {
            clSqlConnection css = new clSqlConnection();
            return css.UpdateMainCart(name,date,address,InvoiceNumber,status);
        }
        public string GenerateId()
        {
            InvoiceNumber inv = new InvoiceNumber();
            return inv.Invoicenumber();
        }
        public bool valied(string UserName,string Password)
        {
            users uc = new users();
            if (uc.Userverified(UserName,Password).Tables[0].Rows.Count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsAdmin(string UserName,string password)
        {
            users uc = new users();
            bool isadmin = false;
            if (uc.Userverified(UserName, password).Tables[0].Rows.Count == 0)
            {
                isadmin = false;
            }
            else
            {
                isadmin = Convert.ToBoolean(uc.Userverified(UserName, password).Tables[0].Rows[0][3]);
            }
            return isadmin;
        }
        public DataSet getinvoiceNumber(string CustmerName)
        {
            clSqlConnection css = new clSqlConnection();
            DataSet ds = css.getinvoiceNumber(CustmerName);
            return ds;
        }
        public int UpdateItems(string name, int pq, double price, string inb)
        {
            clSqlConnection css = new clSqlConnection();
            return css.UpdateItemsList(name,pq,price,inb);
        }
    }
}

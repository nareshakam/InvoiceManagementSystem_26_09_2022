using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataConnect
{
    public class clSqlConnection
    {
        public int InsertCustmerDetails(string InvoiceNumber, string date, string custmerName, string address, string paidstatus)
        {
            int a = 0;

            string ConnectingString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();

            string query = "INSERT INTO CustmerInformation VALUES('" + InvoiceNumber + "','" + date + "','" + custmerName + "','" + address + "','" + paidstatus + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                a = cmd.ExecuteNonQuery();
                return a;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataSet getCart(string InvoiceNumber)
        {
            //1.sql connection
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object
            //Stroed Procedures
            SqlCommand cmd = new SqlCommand("SELECT ProductName,ProductQuantity,ProductPrice FROM InvoiceCart where InvoiceNumber ='" + InvoiceNumber + "'", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            //Close the connection
            conn.Close();
            return ds;
        }
        public double getTotalAmount(string InvoiceNumber)
        {
            //1.sql connection
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            double amount = 0;
            try
            {
                //2.fire the Command object
                //Stroed Procedures
                SqlCommand cmd = new SqlCommand("SELECT SUM(ProductPrice) FROM InvoiceCart where InvoiceNumber ='" + InvoiceNumber + "'", conn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                amount = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                return amount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //Close the connection
                conn.Close();
            }
        }
        public DataSet ScearchInvoice(string InvoiceNumber)
        {
            //1.sql connection
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object
            //Stroed Procedures
            SqlCommand cmd = new SqlCommand("SELECT ProductName,ProductQuantity,ProductPrice FROM InvoiceCart where InvoiceNumber ='" + InvoiceNumber + "'", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            //Close the connection
            conn.Close();
            return ds;
        }
        public bool Status(string InvoiceNumber)
        {
            //1.sql connection
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object
            //Stroed Procedures
            SqlCommand cmd = new SqlCommand("SELECT InvoiceStatus FROM CustmerInformation WHERE InvoiceNumber ='" + InvoiceNumber + "'", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            //Close the connection
            conn.Close();
            string paid = ds.Tables[0].Rows[0][0].ToString();
            if (paid == "Paid")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void InsertItems(string pname,int pquantity,double pprice,string InvoiceNumber)
        {
            string ConnectingString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();
            string query = "INSERT INTO InvoiceCart VALUES('" + pname + "'," + pquantity + "," + pprice + ",'" + InvoiceNumber + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int DeleteCart(string Invoicenumber)
        {
            string ConnectingString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();
            string query = "DELETE FROM InvoiceCart where InvoiceNumber = '" + Invoicenumber + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            return a;
        }
        public int DeleteMainCart(string InvoiceNumber)
        {
            string ConnectingString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();
            string query = "DELETE FROM CustmerInformation where InvoiceNumber = '" + InvoiceNumber + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            return a;
        }
        public int maxId()
        {
            string ConnectingString = ConfigurationManager.ConnectionStrings["DbCon"].ToString(); 
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();
            string query = "select invoicenumber from invoicecart where id = (select max(id) from invoicecart)";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            conn.Close();
            return id;
        }
        public DataSet MainCart()
        {
            //1.sql connection
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object
            //Stroed Procedures
            SqlCommand cmd = new SqlCommand("SELECT * FROM CustmerInformation", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            //Close the connection
            conn.Close();
            return ds;
        }
        public DataSet MainCart(string invoiceNumber)
        {
            //1.sql connection
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object
            //Stroed Procedures
            SqlCommand cmd = new SqlCommand("SELECT * FROM CustmerInformation WHERE InvoiceNumber = '"+invoiceNumber+"'", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            //Close the connection
            conn.Close();
            return ds;
        }
        public int UpdateMainCart(string name,string date,string adress,string InvoiceNumber,string status)
        {
            string ConnectingString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();
            string query = "UPDATE CustmerInformation SET InvoiceDate ='"+date+"',Custmername = '"+name+"',CustmerAdress = '"+adress+"',InvoiceStatus = '"+status+"' WHERE InvoiceNumber = '"+InvoiceNumber+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            return a;
        }
        public DataSet getinvoiceNumber(string CustmerName,string date)
        {
            //1.sql connection
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //2.fire the Command object
            //Stroed Procedures
            SqlCommand cmd = new SqlCommand("SELECT * FROM CustmerInformation WHERE Custmername LIKE '%"+CustmerName+"%' OR InvoiceDate = '"+date+"'", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            //Close the connection
            conn.Close();
            //string InvoiceNumber = ds.Tables[0].Rows[0][0].ToString();
            return ds;
        }
        public int UpdateItemsList(string name,int pq,double price,string inb)
        {
            string ConnectingString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectingString);
            conn.Open();
            string query = "UPDATE InvoiceCart SET ProductQuantity = " + pq + ",ProductPrice = " + price + " WHERE InvoiceNumber = '" + inb + "' AND ProductName ='" + name + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            return a;
        }
    }
}
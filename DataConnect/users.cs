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
    public class users
    {
        public DataSet Userverified(string UserName,string Password)
        {
            String ConnectionString = ConfigurationManager.ConnectionStrings["DbCon"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users Where UserName = '"+UserName+"' AND Password = '"+Password+"'", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}

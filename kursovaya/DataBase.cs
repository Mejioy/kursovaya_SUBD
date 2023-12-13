using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    public class DataBase
    {
        SqlConnection con;
        public DataBase(string login, string password)
        {
            con = new SqlConnection($@"Data Source=MELDY\SQLEXPRESS;Initial Catalog=detail;Integrated Security=False;User ID={login};Password={password};");
        }
        //SqlConnection con = new SqlConnection(@"Data Source=MELDY\SQLEXPRESS;Initial Catalog=detail;Integrated Security=True");
        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
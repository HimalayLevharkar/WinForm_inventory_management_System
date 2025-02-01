using System.Data;
using System.Data.SqlClient;

namespace GrabNGoAppliction
{
    class DBConnect
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8TM23T0M\SQLEXPRESS;Initial Catalog=GrabNGo_DB;Integrated Security=True;TrustServerCertificate=True");
        public SqlConnection GetCon()
        {
            return con;
        }
        public void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

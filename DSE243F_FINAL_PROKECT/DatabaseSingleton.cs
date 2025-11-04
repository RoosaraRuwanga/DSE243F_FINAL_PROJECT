using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE243F_FINAL_PROKECT
{
    class DatabaseSingleton
    {
        private static string connectionString = @"Data Source=DESKTOP-SN798OJ\SQLEXPRESS;Initial Catalog=FinalProject;Integrated Security=True;";
        private static SqlConnection DBConnection = new SqlConnection(connectionString);

        public static SqlConnection GetDBCon()
        {
            if(DBConnection == null)
            {
                DBConnection = new SqlConnection(connectionString);
            }
            if(DBConnection.State == System.Data.ConnectionState.Closed)
            {
                DBConnection.Open();
            }
            return DBConnection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyon
{
    public static class Database
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=RealEstate;Integrated Security=True");

        public static void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public  static void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}

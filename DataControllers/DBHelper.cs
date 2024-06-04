using DataModels;
using System.Data.SqlClient;

namespace DataControllers
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D4M3HH9\\SQLEXPRESS;Initial Catalog=DBLabFinal;Integrated Security=True");
            return connection;
        }
    }
}

using DataModels;
using System.Data.SqlClient;

namespace DataControllers
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=QASIM-DESKTOP\\SQLEXPRESS;Initial Catalog=VPLabFinalQ2;Integrated Security=True");
            return connection;
        }
    }
}

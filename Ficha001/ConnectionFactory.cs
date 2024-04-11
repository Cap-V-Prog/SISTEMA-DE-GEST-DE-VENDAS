using System.Configuration;
using MySql.Data.MySqlClient;

namespace Ficha001
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string conection = ConfigurationManager.ConnectionStrings["minipreco"].ConnectionString;
            return new MySqlConnection(conection);
        }
    }
}
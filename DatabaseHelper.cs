using MySql.Data.MySqlClient;
using System.Data;

namespace CyberChatbot.Data
{
    public class DatabaseHelper
    {
        private string connectionString =
            "server=localhost;database=CyberChatbot;uid=root;pwd=;";

        // Execute INSERT, UPDATE, DELETE
        public void ExecuteQuery(string query)
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd =
                    new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        // SELECT data
        public DataTable SelectQuery(string query)
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }
    }
}
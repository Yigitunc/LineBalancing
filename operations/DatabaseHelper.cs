using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HatDengelemeProject.operations
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=95.0.151.218;Port=3306;Database=line_balancing;Uid=produser;Pwd=eO8!ym*9SY;";

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during database access
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataTable;
        }

        public void ExecuteNonQuery(string query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during database access
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

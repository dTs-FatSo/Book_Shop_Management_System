using System.Data.SqlClient;


namespace Book_Shop_Management_System
{
    public class DBConnection
    {

        private const string connectionString = @"Server=LAPTOP-4K558HIP;Database=BKMANAGEMENT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        public SqlCommand GetQuery(string query)
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);

                return cmd;
            }

        

    }
}

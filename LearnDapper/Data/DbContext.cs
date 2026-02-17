using Microsoft.Data.SqlClient;
using System.Data;

namespace LearnDapper.Data
{
    public class DbContext
    {

        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=master;Integrated Security=True;TrustServerCertificate=True;";

        public IDbConnection connection => new SqlConnection(connectionString);

    }
}

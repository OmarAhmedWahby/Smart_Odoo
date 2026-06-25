using System.Data.Odbc;

namespace Smart_Odoo.Models
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(IConfiguration configuration)
        {
            _connectionString =
                configuration.GetConnectionString("DatabricksConnection");
        }

        public OdbcConnection CreateConnection()
        {
            return new OdbcConnection(_connectionString);
        }
    }
}

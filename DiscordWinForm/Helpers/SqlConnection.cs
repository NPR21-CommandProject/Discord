using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DiscordWinForm.Helpers
{
    public class ConnectionStrings
    {
        public string MSSQLServerConnection { get; set; }
    }

    static class SqlConnection
    {
        public static readonly System.Data.SqlClient.SqlConnection sqlConnection;

        static SqlConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            sqlConnection = new System.Data.SqlClient.SqlConnection(configuration.GetConnectionString("MSSQLServerConnection") ?? "Data Source=.;Integrated Security=True;"); // + $" Initial Catalog=DiscordDb;");
            sqlConnection.Open();

            SqlCommand sql = sqlConnection.CreateCommand();
            sql.CommandText = "Use DiscordDb";
            sql.ExecuteNonQuery();
        }

        
    }
}

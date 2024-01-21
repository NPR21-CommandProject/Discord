using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.Helpers
{
    static class Connection
    {
        public static readonly SqlConnection sqlConnection;

        static Connection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            sqlConnection = new SqlConnection(configuration.GetConnectionString("MSSQLServerConnection") ?? "Data Source=.;Integrated Security=True;" + $"Initial Catalog=Discord;");
            sqlConnection.Open();
        }

        
    }
}

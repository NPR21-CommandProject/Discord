using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.Helpers
{
    internal class DiscordContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=20.65.144.204;User ID=kaban;Password=9[nV`e7VN`0%;MultipleActiveResultSets=true;");

            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();
            
            string conStr = configuration.GetConnectionString(("MSSQLServerConnection") ?? "Data Source=.;Integrated Security=True;"); // + $" Initial Catalog=DiscordDb;");
            
        }
    }
}

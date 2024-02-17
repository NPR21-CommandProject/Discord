using DB.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Data
{
    public class DiscordContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string conStr = configuration.GetConnectionString("MSSQLServerConnection") ??
                "Data Source=20.65.144.204;User ID=kaban;Password=9[nV`e7VN`0%;Initial Catalog=discord;MultipleActiveResultSets=true;";

            optionsBuilder.UseSqlServer(conStr);
        }
    }
}

using DiscordWinForm.Data.Entities;
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
        public DbSet<FriendEntity> Friends { get; set; }
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasIndex(u => u.Username)
                .IsUnique();
            modelBuilder.Entity<FriendEntity>()
            .HasOne(f => f.Friend1)
            .WithMany()
            .HasForeignKey(f => f.Friend1ID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FriendEntity>()
                .HasOne(f => f.Friend2)
                .WithMany()
                .HasForeignKey(f => f.Friend2ID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

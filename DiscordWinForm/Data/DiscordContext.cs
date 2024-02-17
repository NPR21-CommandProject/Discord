using DiscordWinForm.Data;
using DiscordWinForm.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.ApplicationServices;
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
            modelBuilder.Entity<FriendEntity>()
        .HasKey(f => new { f.Friend1ID, f.Friend2ID });
        }

        public void AddUser(string username, string nickname, string password, string picture, string ip)
        {
            var user = new UserEntity
            {
                Username = username,
                Nickname = nickname,
                Password = password,
                Picture = picture,
                IP = ip
            };

            Users.Add(user);
            SaveChanges();
        }

        public void UpdateIp(string username, string password, string newIp)
        {
            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                user.IP = newIp;
                SaveChanges();
            }
        }

        public void AddFriends(int friend1ID, int friend2ID)
        {
            if (friend1ID != friend2ID)
            {
                var friend = new FriendEntity { Friend1ID = friend1ID, Friend2ID = friend2ID };
                Friends.Add(friend);
                SaveChanges();
            }
        }
    }
}

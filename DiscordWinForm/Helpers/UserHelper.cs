using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Drawing;
using DiscordWinForm.Entities;

namespace DiscordWinForm.Helpers
{
    internal class UserHelper
    {
        public UserHelper() { }

        public User GetUser(string Username, string Password)
        {
            SqlCommand sqlCommand = Connection.sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"Select ID, Username, Nickname, Password, Picture FROM GetUser('{Username}', '{Password}');";
            using(SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if(reader.Read())
                {
                    return new User((int)reader["ID"], reader["Username"].ToString(), reader["NickName"].ToString(),
                        reader["Password"].ToString(), reader["Picture"].ToString());
                }
                return null;
            }
        }

        static public void AddUser(string Username, string Nickname, string Password, string PictureURL)
        {
            SqlCommand sqlCommand = Connection.sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"EXEC AddUser @Username = '{Username}', @Nickname = '{Nickname}', " +
                $" @Password = '{Password}', @Picture = '{PictureURL}';";
            sqlCommand.ExecuteNonQuery();
        }
    }
}

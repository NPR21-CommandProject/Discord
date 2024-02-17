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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DiscordWinForm.StartupManagers.DatabaseManagers
{
    internal class UserDbHelper
    {
        public UserDbHelper() { }

        public void InitUser(string Username, string Password)
        {
            SqlCommand sqlCommand = SqlConnection.sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"Exec UpdateIP @Username = '{Username}', @Password = '{Password}', @IP = '127.0.0.1'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = $"Select ID, Username, Nickname, Password, Picture FROM GetUser('{Username}', '{Password}');";
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    User.InitUser((int)reader["ID"], reader["Username"].ToString(), reader["NickName"].ToString(),
                        reader["Password"].ToString(), reader["Picture"].ToString());
                }
                return;
            }
        }

        static public void AddUser(string Username, string Nickname, string Password, string PictureURL, string IP)
        {

            SqlCommand sqlCommand = SqlConnection.sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"EXEC AddUser @Username = '{Username}', @Nickname = '{Nickname}', " +
                $" @Password = '{Password}', @Picture = '{PictureURL}', @IP = '{IP}';";
            sqlCommand.ExecuteNonQuery();
        }

        static public void GetFriends()
        {
            SqlCommand sqlCommand = SqlConnection.sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"SELECT ID, Username, Nickname, Picture, IP FROM GetTableOfFriends({User.ID})";
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Friend friend = new Friend((int)reader["ID"], reader["Username"].ToString(), reader["Nickname"].ToString(),
                        reader["Picture"].ToString(), reader["IP"].ToString());
                    User.Friends.Add(friend);
                }
            }
        }
    }
}

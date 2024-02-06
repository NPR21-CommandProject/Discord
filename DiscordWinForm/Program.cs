using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;
using DiscordWinForm.StartupManagers;

namespace DiscordWinForm
{
    public enum RequestType
    {
        AddClient,
        AudioConnectWith,
        SendTextMessage
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            //SqlCommand sql = Connection.sqlConnection.CreateCommand();
            //sql.CommandText = "Create Database DiscordDb";
            //sql.ExecuteNonQuery();
            //sql.CommandText = "Use DiscordDb";
            //sql.ExecuteNonQuery();
            //sql.CommandText = "CREATE TABLE tblUsers(\r\n\tID int primary key identity,\r\n\tUsername nvarchar(256) not null unique,\r\n\tNickname nvarchar(128) not null,\r\n\tPassword nvarchar(256) not null CHECK (Password LIKE '%[0-9]%' AND Password LIKE '%[A-Za-z]%'),\r\n\tPicture nvarchar(2048)\r\n)";
            //sql.ExecuteNonQuery();
            //sql.CommandText = "CREATE TABLE tblFriends(\r\n\tID int primary key identity,\r\n\tFriend1ID int foreign key REFERENCES tblUsers(ID),\r\n\tFriend2ID int foreign key REFERENCES tblUsers(ID)\r\n)";
            //sql.ExecuteNonQuery();
            //sql.CommandText = "CREATE PROCEDURE AddUser(@Username nvarchar(256), @Nickname nvarchar(128), @Password nvarchar(256), @Picture nvarchar(2048)) AS\r\n\tINSERT INTO tblUsers(Username, Nickname, [Password], Picture)\r\n\tVALUES (@Username, @Nickname, @Password, @Picture);";
            //sql.ExecuteNonQuery();
            //sql.CommandText = "CREATE FUNCTION GetUser(@Username nvarchar(256), @Password nvarchar(256))\r\nRETURNS TABLE AS\r\n\tRETURN SELECT ID, Username, Nickname, [Password], Picture FROM tblUsers\r\n\tWHERE Username = @Username and Password = @Password;";






            AuthorizationManager uah = new AuthorizationManager();
            if(uah.Deserialize()) {
                Application.Run(new AuthorizationForm(uah));
            }
            else
            {
                // see https://aka.ms/applicationconfiguration.
                Application.Run(new InitialForm());
            }
        }
    }
}
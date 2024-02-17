using DiscordWinForm.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.Entities
{
    /// <summary>
    /// Class that contain all necessary information about user
    /// </summary>
    public static class User
    {
        public static int ID;
        public static string Username;
        public static string Nickname;
        private static string Password;
        public static string PictureURL;
        public static List<Friend> Friends;
        public static State state;

        public static void InitUser(int iD, string username, string nickname, string password, string picture)
        {
            ID = iD;
            Username = username;
            Nickname = nickname;
            Password = password;
            PictureURL = picture;
            Friends = new List<Friend>();
        }
    }
}

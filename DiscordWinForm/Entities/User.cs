using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.Entities
{
    /// <summary>
    /// Class that contain all necessary information about user
    /// </summary>
    public class User
    {
        private readonly int ID;
        private readonly string Username;
        private readonly string Password;
        public readonly string Nickname;
        public string PictureURL;
        public List<Friend> Friends;
        public string IP;
        public string Port;


        public User(int iD, string username, string password, string nickname, string picture)
        {
            ID = iD;
            Username = username;
            Password = password;
            Nickname = nickname;
            PictureURL = picture;
        }

        
    }
}

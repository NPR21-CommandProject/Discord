using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.Entities
{
    public class Friend
    {
        private readonly int ID;
        private readonly string Username;
        public readonly string Nickname;
        public string PictureURL;
        public string IP;
        public string Port;


        public Friend(int iD, string username, string password, string nickname, string picture)
        {
            ID = iD;
            Username = username;
            Nickname = nickname;
            PictureURL = picture;
        }
    }
}

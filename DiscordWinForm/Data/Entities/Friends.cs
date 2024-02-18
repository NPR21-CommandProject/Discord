
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.Entities
{
    public enum State
    {
        Offline,
        Online,
        InVoiceChat,
        InVideoChat
    }

    public class Friends
    {
        private readonly int ID;
        public readonly string Username;
        public readonly string Nickname;
        public string PictureURL;
        public string IP;
        public readonly int PortState = 57118; //this port is used for checking state of friend
        public readonly int PortAudio = 57119;
        public EndPoint StateEndPoint;
        public EndPoint AudioEndPoint;
        public volatile State state;

        public Friends(int iD, string username, string nickname, string picture, string iP)
        {
            state = State.Offline;
            ID = iD;
            Username = username;
            Nickname = nickname;
            PictureURL = picture;
            IP = iP;
            StateEndPoint = new IPEndPoint(IPAddress.Parse(IP), PortState);
            AudioEndPoint = new IPEndPoint(IPAddress.Parse(IP), PortAudio);
        }
    }
}
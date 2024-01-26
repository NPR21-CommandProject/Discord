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
    public class User
    {
        public readonly int ID;
        public readonly string Username;
        public readonly string Nickname;
        private readonly string Password;
        public string PictureURL;
        public string IP;
        public int Port = 57119;
        public List<Friend> Friends;
        public Socket socket;
        public EndPoint endPoint;
        public State state;


        public User(int iD, string username,  string nickname, string password, string picture)
        {
            ID = iD;
            Username = username;
            Nickname = nickname;
            Password = password;
            PictureURL = picture;
            Friends = new List<Friend>(); 
            IP = GetIP();
            endPoint = new IPEndPoint(IPAddress.Parse(IP), Port);
            InitializeSockets();
            socket.Bind(endPoint);
        }

        private void InitializeSockets()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }

        static public string GetIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork) return ip.ToString();
            }
            return "127.0.0.1";
        }
    }
}

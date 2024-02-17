using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DiscordWinForm.Entities;

namespace DiscordWinForm.Helpers
{
//    public static class FriendHelper
//    {
//        private static Socket socket;
//        private static TcpListener tcpListener;
//        private static IPEndPoint userEndPoint;
//        private static ushort port = 57118;
//
//        public static void InitHelper(User user)
//        {
//            userEndPoint = new IPEndPoint(IPAddress.Parse(user.IP), port);
//            tcpListener = new TcpListener(userEndPoint);
//            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
//        }
//
//        public static async Task SendUserState(User user)
//        {
//            while (true)
//            {
//                for (int i = 0; i < user.Friends.Count; i++)
//                {
//                    try
//                    {
//                        socket.Connect(user.Friends[i].StateEndPoint);
//                        byte[] buffer = new byte[2];
//                        buffer = BitConverter.GetBytes(((short)user.state));
//                        socket.Send(buffer);
//                        socket.Disconnect(true);
//                    }
//                    catch (Exception ex) { socket.Disconnect(true); }
//                }
//                Thread.Sleep(1000);
//            }
//
//        }
//
//        public static async Task MonitorFriendsStates(User user)
//        {
//            tcpListener.Start();
//
//            while (true)
//            {
//                TcpClient client = tcpListener.AcceptTcpClient();
//                if (client.Connected)
//                {
//                    byte[] buffer = new byte[2];
//                    for (int i = 0; i < user.Friends.Count; i++)
//                    {
//                        if (user.Friends[i].StateEndPoint == client.Client.RemoteEndPoint)
//                        {
//                            client.GetStream().Read(buffer, 0, buffer.Length);
//                            user.Friends[i].state = (State)BitConverter.ToInt16(buffer);
//                        }
//                    }
//                }
//                Thread.Sleep(1000);
//            }
//        }
//    }
}
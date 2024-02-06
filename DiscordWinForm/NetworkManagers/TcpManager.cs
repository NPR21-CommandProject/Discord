using Azure.Core;
using DiscordWinForm.ChatManagers;
using DiscordWinForm.Entities;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.NetworkManagers
{



    public static class TcpManager
    {
        private static byte[] _requestInfo;
        private static int _port = 5518;
        public static Socket _socket;

        static TcpManager()
        {
            IPAddress serverIP = GetIP();                                          //Set server IP!!!!!!!
            IPEndPoint serverIPEndPoint = new IPEndPoint(serverIP, _port);                                           
            
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            _socket.Connect(serverIPEndPoint);

            _requestInfo = new byte[9];
            Array.Copy(BitConverter.GetBytes(User.ID), 0, _requestInfo, 1, 4);
        }

        private static void SetRequestType(RequestType requestType)
        {
            _requestInfo[0] = (byte)requestType;
        }

        /// <summary>
        /// Create new thread for accepting incoming messages
        /// </summary>
        public static void StartListenThread()
        {
            _socket.Listen();
            Task.Run(() => { _socket.BeginAccept(Accept, null); });
        }

        private static async void Accept(IAsyncResult res)  //Work in theory
        {
            try
            {
                _socket.EndAccept(out byte[] buffer, res);
                TextChatManager.SetMessage(buffer);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { _socket.BeginAccept(Accept, null); }
        }

        public static async Task SendTextMessageAsync(string message, int recipientID)
        {
            try
            {
                _socket.SendAsync(CreateSendRequest(message, recipientID), 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static byte[] CreateSendRequest(string message, int recipientID)
        {
            SetRequestType(RequestType.SendTextMessage);

            byte[] temp = Encoding.BigEndianUnicode.GetBytes(message);
            byte[] messageToSend = new byte[temp.Length + 9];

            Array.Copy(BitConverter.GetBytes(recipientID), 0, _requestInfo, 5, 4);
            Array.Copy(_requestInfo, 0, messageToSend, 0, 9);
            Array.Copy(temp, 0, messageToSend, 9, temp.Length);

            return messageToSend;
        }

        public static void SendNewClientRequest()
        {
            
            try { 
                _socket.Send(CreateNewClientRequest(), 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static byte[] CreateNewClientRequest()
        {
            SetRequestType(RequestType.AddClient);
            byte[] request = new byte[5];
            Array.Copy(_requestInfo, 0, request, 0, 5);
            return request;
        }
       








        private static IPAddress GetIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork) return ip;
            }
            //return new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
            return null;
        }
    }
}

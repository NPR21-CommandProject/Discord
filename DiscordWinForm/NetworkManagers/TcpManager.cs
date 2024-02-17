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
        private static int _serverPort = 5518;
        private static int _clientPort = 5517;
        private static IPEndPoint _serverIPEndPoint;
        private static Socket _sendingSocket;
        private static TcpListener _tcpListener;

        static TcpManager()
        {
            IPAddress serverIP = IPAddress.Parse("15.188.224.187");                                          //Set server IP!!!!!!!
            _serverIPEndPoint = new IPEndPoint(serverIP, _serverPort);
            InitSendingSocket();
            _sendingSocket.Connect(_serverIPEndPoint);

            _requestInfo = new byte[9];
            Array.Copy(BitConverter.GetBytes(User.ID), 0, _requestInfo, 1, 4);
        }

        private static void InitSendingSocket()
        {
            IPAddress clientIP = Dns.GetHostAddresses(Dns.GetHostName())[1];
            IPEndPoint clientIPEndPoint = new IPEndPoint(clientIP, _serverPort);
            _sendingSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _sendingSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            _sendingSocket.Bind(clientIPEndPoint);
        }
        /// <summary>
        /// Initialize of _tcpListener and start of listening for incoming messages
        /// </summary>
        public static async void InitTcpListener()
        {
            IPAddress clientIP = Dns.GetHostAddresses(Dns.GetHostName())[1];
            IPEndPoint clientIPEndPoint = new IPEndPoint(clientIP, _clientPort);
            _tcpListener = new TcpListener(clientIPEndPoint);
            _tcpListener.Start();
            _tcpListener.BeginAcceptTcpClient(Accept, null);
        }

        private static void SetRequestType(RequestType requestType)
        {
            _requestInfo[0] = (byte)requestType;
        }

        private static async void Accept(IAsyncResult res)  //Work in theory
        {
            try
            {
                TcpClient tcpClient = _tcpListener.EndAcceptTcpClient(res);
                byte[] buffer = new byte[tcpClient.Available - 9];
                tcpClient.GetStream().Read(buffer, 0, buffer.Length);
                TextChatManager.NewMessageReceived(ref buffer);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { _tcpListener.BeginAcceptTcpClient(Accept, null); }
        }

        public static async Task SendTextMessageAsync(string message, int recipientID)
        {
            try
            {
                MessageBox.Show($"Is socket connected : {_sendingSocket.Connected}");
                _sendingSocket.Send(CreateSendRequest(message, recipientID), 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static byte[] CreateSendRequest(string message, int recipientID)
        {
            SetRequestType(RequestType.SendTextMessage);

            byte[] temp = Encoding.Default.GetBytes(message);
            byte[] messageToSend = new byte[temp.Length + 9];

            Array.Copy(BitConverter.GetBytes(recipientID), 0, _requestInfo, 5, 4);
            Array.Copy(_requestInfo, 0, messageToSend, 0, 9);
            Array.Copy(temp, 0, messageToSend, 9, temp.Length);

            return messageToSend;
        }

        public static void SendNewClientRequest()
        {
            
            try { 
                _sendingSocket.Send(CreateNewClientRequest(), 0);
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
       


    }
}

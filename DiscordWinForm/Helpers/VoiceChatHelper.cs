using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DiscordWinForm.Entities;

namespace DiscordWinForm.Helpers
{
    static public class VoiceChatHelper
    {
        private static List<Socket> sockets;
        private static TcpListener tcpListener;
        private static IPEndPoint userEndPoint;
        private static ushort port = 57119;
        private static volatile bool AudioChatClosed;

        public static async Task StartVoiceChat(User user)
        {
            try
            {
                AudioChatClosed = false;
                userEndPoint = new IPEndPoint(IPAddress.Parse(user.IP), port);
                sockets = new List<Socket>();
                tcpListener = new TcpListener(userEndPoint);

                for (int i = 0; i < user.Friends.Count; i++)
                {
                        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                        socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                        socket.Connect(user.Friends[i].AudioEndPoint);
                        sockets.Add(socket);
                }

                tcpListener.Start();
                Task.Run(() => StartSendingAudioAsync());
                Task.Run(() => StartReceivingAudioAsync());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static async Task StartReceivingAudioAsync()
        {
            try
            {
                while (true)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    Task.Run(() => AudioHelper.RunAudioMessageAsync(client.GetStream()));
                    if (AudioChatClosed) break;
                }
                tcpListener.Stop();
            }
            catch(Exception e)
            { 
                MessageBox.Show(e.Message);
            }
        }

        private static async Task StartSendingAudioAsync()
        {
            try
            {
                while (true)
                {
                    AudioHelper.Record(1000);
                    foreach (Socket socket in sockets) socket.Send(AudioHelper.AudioBuffer);
                    if (AudioChatClosed) return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private static void StopChat()
        {
            AudioChatClosed = true;
        }
    }
}
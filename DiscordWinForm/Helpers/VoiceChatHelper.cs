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

                tcpListener.Start();
                Task.Run(() => StartReceivingAudioAsync());
                for (int i = 0; i < user.Friends.Count; i++)
                {
                    try
                    {
                        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                        socket.Connect(user.Friends[i].AudioEndPoint);
                        sockets.Add(socket);
                    }
                    catch(Exception ex)
                    { ; }
                }
                        
                Task.Run(() => StartSendingAudioAsync());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static async Task StartReceivingAudioAsync()
        {
            AudioHelper.ChangeTimings(1000);
            try
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                while (true)
                {
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
                    await AudioHelper.Record(1000);
                    for (int i = 0; i < sockets.Count; i++) {
                        try { sockets[i].SendAsync(AudioHelper.AudioBuffer); }
                        catch (Exception ex) {; }
                    }
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
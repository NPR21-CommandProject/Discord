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

        public static async Task StartVoiceChat(User user) {
            AudioChatClosed = false;
            userEndPoint = new IPEndPoint(IPAddress.Parse(user.IP), port);
            sockets = new List<Socket>();
            tcpListener = new TcpListener(userEndPoint);

            for(int i = 0; i < user.Friends.Count; i++)
            {
                if (user.Friends[i].state == State.InVoiceChat)
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    socket.Connect(user.Friends[i].AudioEndPoint);
                    sockets.Add(socket);
                }
            }
            
            tcpListener.Start();
            Task.Run(() =>StartSendingAudioAsync());
            Task.Run(() => StartReceivingAudioAsync());
        }

        private static async Task StartReceivingAudioAsync()
        {
            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Task.Run(() => AudioHelper.RunAudioMessageAsync(client.GetStream()));
                if (AudioChatClosed) break;
            } tcpListener.Stop();
        }

        private static async Task StartSendingAudioAsync()
        {
            while (true)
            {
                AudioHelper.Record(20);
                foreach (Socket socket in sockets) Task.Run(() => socket.SendAsync(AudioHelper.AudioBuffer));
                if (AudioChatClosed) return;
            }
        }

        private static void StopChat()
        {
            AudioChatClosed = true;
        }
    }
}

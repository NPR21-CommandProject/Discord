using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DiscordWinForm.Entities;

namespace DiscordWinForm.ChatManagers
{
    //    static public class VoiceChatHelper
    //    {
    //        private static List<Socket> sockets;
    //        private static volatile UdpClient udpClient;
    //        private static IPEndPoint userEndPoint;
    //        private static ushort port = 57119;
    //        private static volatile bool AudioChatClosed;
    //
    //        public static async Task StartVoiceChat()
    //        {
    //            try
    //            {
    //                
    //
    //
    //                AudioChatClosed = false;
    //                userEndPoint = new IPEndPoint(IPAddress.Parse(user.IP), 5555);  /// Change LATER!!!!!!!!!!!!!!!!!!!
    //                sockets = new List<Socket>();
    //                udpClient = new UdpClient(userEndPoint);
    //
    //
    //                Task.Run(() => StartSendingAudioAsync(user));
    //                Task.Run(() => StartReceivingAudioAsync());
    //            }
    //            catch(Exception e)
    //            {
    //                MessageBox.Show(e.Message);
    //            }
    //        }
    //
    //        private static async Task StartReceivingAudioAsync()
    //        {
    //            
    //            AudioHelper.ChangeTimings(1000);
    //            try
    //            {
    //                udpClient.Connect(userEndPoint);
    //                while (true)
    //                {
    //                    byte[] message = udpClient.Receive(ref userEndPoint);
    //                    AudioHelper.RunAudioMessageAsync(message);
    //                }
    //            }
    //            catch(Exception e)
    //            { 
    //                MessageBox.Show(e.Message);
    //            }
    //        }
    //
    //        private static async Task StartSendingAudioAsync(User user)
    //        {
    //            try
    //            {
    //                for (int i = 0; i < user.Friends.Count; i++)
    //                {
    //                    try
    //                    {
    //                        //Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
    //                        //socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
    //                        ////socket.Connect(user.Friends[i].AudioEndPoint);
    //                        //socket.Connect(userEndPoint);
    //                        //sockets.Add(socket);
    //                        udpClient.Connect(userEndPoint);
    //                    } catch (Exception ex) {; }
    //                }
    //                while (true)
    //                {
    //                    await AudioHelper.Record();
    //                    for (int i = 0; i < sockets.Count; i++) {
    //                        try { udpClient.SendAsync(AudioHelper.AudioBuffer, AudioHelper.AudioBuffer.Length);
    //                              //sockets[i].SendAsync(AudioHelper.AudioBuffer);
    //                              }
    //                        catch (Exception ex) {; }
    //                    }
    //                    if (AudioChatClosed) return;
    //                }
    //            }
    //            catch (Exception e)
    //            {
    //            }
    //
    //        }
    //
    //
    //        private static void StopChat()
    //        {
    //            AudioChatClosed = true;
    //        }
    //    }
}
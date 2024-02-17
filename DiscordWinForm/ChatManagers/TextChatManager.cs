using DiscordWinForm.Entities;
using DiscordWinForm.NetworkManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWinForm.ChatManagers
{

    public static class TextChatManager
    {
        private static volatile string _message;
        private static Action<string> _eventHandler;
        public static void SetIncomingMessageHandler(Action<string> eventHandler)
        {
            _eventHandler = eventHandler;
        }

        public static void NewMessageReceived(ref byte[] messageInBytes) =>
            _eventHandler?.Invoke(ConvertByteMessageToString(ref messageInBytes));

        public static void SendMessage(string message, int friendsID) =>
            TcpManager.SendTextMessageAsync(message, friendsID);

        private static string ConvertByteMessageToString(ref byte[] message)
        {
            string strMessage = System.Text.Encoding.Default.GetString(message);
            return strMessage;
        }
    }
}

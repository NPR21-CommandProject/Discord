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
        /// <summary>
        /// Indicate whether new message was received
        /// </summary>
        public static bool _Available;

        public static async Task SetMessage(byte[] buffer)
        {
            _message = Encoding.BigEndianUnicode.GetString(buffer, 9, buffer.Length - 9);
            _Available = true;
        }

        public static async Task<string> GetMessage()
        {
            _Available = false;
            return _message;
        }

        public static async Task SendMessage(string message, int friendsID)
        {
            TcpManager.SendTextMessageAsync(message, friendsID);
        }
    }
}

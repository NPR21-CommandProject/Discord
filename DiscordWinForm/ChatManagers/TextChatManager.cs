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

        public static async void IncomingMessageEventHandler()
        {

        }

        public static async Task SendMessage(string message, int friendsID)
        {
            TcpManager.SendTextMessageAsync(message, friendsID);
        }
    }
}

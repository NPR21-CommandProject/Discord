using DiscordWinForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Net.Http.Headers;
using DiscordWinForm.Helpers;

namespace DiscordWinForm
{
    public partial class TestForm : Form
    {
        User user;
        public TestForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private async void TestForm_Load(object sender, EventArgs e)
        {
            user.state = State.InVoiceChat;
            
            Task configureFriends = ConfigureFriends();
            Task.Run(() => VoiceChatHelper.StartVoiceChat(user));

        }

        async Task ConfigureFriends()
        {
            FriendHelper.InitHelper(user);
            Task.Run(() => FriendHelper.MonitorFriendsStates(user));
            Task.Run(() => FriendHelper.SendUserState(user));
            return;
        }
    }
}

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
using DiscordWinForm.StartupManagers;

namespace DiscordWinForm
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private async void TestForm_Load(object sender, EventArgs e)
        {
            NetworkStartupManager.StartNetworkCommunication();


            Task.Run(() => ConfigureFriends());
        }

        async Task ConfigureFriends()
        {
            //FriendHelper.InitHelper(user);
            //Task.Run(() => FriendHelper.MonitorFriendsStates(user));
            //Task.Run(() => FriendHelper.SendUserState(user));
            return;
        }
    }
}

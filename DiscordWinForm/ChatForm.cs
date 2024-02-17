using DiscordWinForm.ChatManagers;
using DiscordWinForm.StartupManagers;

namespace WinFormsApp1
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private void EmojiButton_Click(object sender, EventArgs e)
        {

        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            NetworkStartupManager.StartNetworkCommunication();
            TextChatManager.SetIncomingMessageHandler(NewMessageHandler);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TextChatManager.SendMessage(tbMessage.Text, 2);                     //Change ID!!!!
        }

        private void NewMessageHandler(string message)
        {
            if(lbMessages.InvokeRequired) lbMessages.Invoke(() => lbMessages.Items.Add(message));
            else lbMessages.Items.Add(message);
            lbMessages.Refresh();
        }
    }
}

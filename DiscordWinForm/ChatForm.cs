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
            TextChatManager.SendMessage(tbMessage.Text, 3);                     //Change ID!!!!
        }

        private void NewMessageHandler(string message)
        {
            if (lbMessages.InvokeRequired) lbMessages.Invoke(() => lbMessages.Items.Add(message));
            else lbMessages.Items.Add(message);
            lbMessages.Refresh();
        }

        private void lbMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFriendList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle the double-click event
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the double-clicked cell
                string dataBaseName = (string)dgvDatabases.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                TabelsForm dlg = new TabelsForm();
                dlg.DatabaseName = dataBaseName;
                dlg.ShowDialog();
            }
        }
    }
}

using DiscordWinForm.ChatManagers;
using DiscordWinForm.Entities;
using DiscordWinForm.StartupManagers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

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
            // Handle emoji button click
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            // Start network communication
            NetworkStartupManager.StartNetworkCommunication();

            // Set incoming message handler
            TextChatManager.SetIncomingMessageHandler(NewMessageHandler);

            // Load list of friends
            LoadListFriends();
        }

        private void LoadListFriends()
        {
            // Clear the DataGridView's rows and columns
            dgvFriendsList.Rows.Clear();
            dgvFriendsList.Columns.Clear();

            // Add columns to the DataGridView
            dgvFriendsList.Columns.Add("NicknameColumn", "Nickname"); // Assuming Friend has a property called Nickname

            // Add each friend to the DataGridView
            foreach (var friend in User.Friends)
            {
                // Add a row for each friend
                dgvFriendsList.Rows.Add(friend.Nickname);
            }
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            // Send message
            TextChatManager.SendMessage(tbMessage.Text, 3); // Change ID!!!!
        }

        private void NewMessageHandler(string message)
        {
            if (lbMessages.InvokeRequired)
            {
                // If invoking is required, use invoke to add the message to the list box
                lbMessages.Invoke(new Action(() => lbMessages.Items.Add(message)));
            }
            else
            {
                // Otherwise, add the message directly
                lbMessages.Items.Add(message);
            }
        }

        private void lbMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle list box selection change event
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle DataGridView cell content click event
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }
    }
}

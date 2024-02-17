namespace WinFormsApp1
{
    partial class ChatForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmojiButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label1 = new Label();
            dgvFriendList = new DataGridView();
            btnOpenVoiceChat = new Button();
            btnSend = new Button();
            lbMessages = new ListBox();
            tbMessage = new TextBox();
            FileButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFriendList).BeginInit();
            SuspendLayout();
            // 
            // EmojiButton
            // 
            EmojiButton.BackColor = Color.FromArgb(153, 170, 181);
            EmojiButton.FlatStyle = FlatStyle.Popup;
            EmojiButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EmojiButton.Location = new Point(759, 416);
            EmojiButton.Name = "EmojiButton";
            EmojiButton.Size = new Size(29, 23);
            EmojiButton.TabIndex = 2;
            EmojiButton.Text = "😁";
            EmojiButton.UseVisualStyleBackColor = false;
            EmojiButton.Click += EmojiButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 64, 76);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvFriendList);
            panel1.Controls.Add(btnOpenVoiceChat);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 452);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 10;
            label1.Text = "Friends";
            // 
            // dgvFriendList
            // 
            dgvFriendList.BackgroundColor = Color.FromArgb(54, 57, 69);
            dgvFriendList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFriendList.Location = new Point(12, 69);
            dgvFriendList.Name = "dgvFriendList";
            dgvFriendList.Size = new Size(136, 369);
            dgvFriendList.TabIndex = 10;
            dgvFriendList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnOpenVoiceChat
            // 
            btnOpenVoiceChat.BackColor = Color.FromArgb(54, 57, 69);
            btnOpenVoiceChat.BackgroundImageLayout = ImageLayout.None;
            btnOpenVoiceChat.FlatStyle = FlatStyle.Popup;
            btnOpenVoiceChat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOpenVoiceChat.ForeColor = Color.Snow;
            btnOpenVoiceChat.Location = new Point(12, 12);
            btnOpenVoiceChat.Name = "btnOpenVoiceChat";
            btnOpenVoiceChat.Size = new Size(136, 23);
            btnOpenVoiceChat.TabIndex = 6;
            btnOpenVoiceChat.Text = "Join voice chat";
            btnOpenVoiceChat.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(153, 170, 181);
            btnSend.BackgroundImageLayout = ImageLayout.None;
            btnSend.FlatStyle = FlatStyle.Popup;
            btnSend.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSend.Location = new Point(701, 416);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(52, 23);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lbMessages
            // 
            lbMessages.BackColor = Color.FromArgb(54, 57, 69);
            lbMessages.BorderStyle = BorderStyle.None;
            lbMessages.Font = new Font("Microsoft Sans Serif", 16F);
            lbMessages.ForeColor = SystemColors.Window;
            lbMessages.FormattingEnabled = true;
            lbMessages.ItemHeight = 25;
            lbMessages.Location = new Point(170, 10);
            lbMessages.Name = "lbMessages";
            lbMessages.Size = new Size(618, 400);
            lbMessages.TabIndex = 7;
            lbMessages.SelectedIndexChanged += lbMessages_SelectedIndexChanged;
            // 
            // tbMessage
            // 
            tbMessage.BackColor = Color.FromArgb(64, 67, 79);
            tbMessage.BorderStyle = BorderStyle.FixedSingle;
            tbMessage.Location = new Point(205, 415);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(490, 23);
            tbMessage.TabIndex = 8;
            // 
            // FileButton
            // 
            FileButton.BackColor = Color.FromArgb(153, 170, 181);
            FileButton.FlatStyle = FlatStyle.Popup;
            FileButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FileButton.Location = new Point(170, 416);
            FileButton.Name = "FileButton";
            FileButton.Size = new Size(29, 23);
            FileButton.TabIndex = 9;
            FileButton.Text = "📌";
            FileButton.UseVisualStyleBackColor = false;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 69);
            ClientSize = new Size(800, 450);
            Controls.Add(FileButton);
            Controls.Add(tbMessage);
            Controls.Add(lbMessages);
            Controls.Add(panel1);
            Controls.Add(btnSend);
            Controls.Add(EmojiButton);
            Name = "ChatForm";
            Text = "Form1";
            Load += ChatForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFriendList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button EmojiButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button btnSend;
        private Button btnOpenVoiceChat;
        private ListBox lbMessages;
        private TextBox tbMessage;
        private Button FileButton;
        private Label label1;
        private DataGridView dgvFriendList;
    }
}

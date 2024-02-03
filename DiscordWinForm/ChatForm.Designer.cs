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
            btnOpenVoiceChat = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            FileButton = new Button();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(btnOpenVoiceChat);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 452);
            panel1.TabIndex = 5;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(153, 170, 181);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(701, 416);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 4;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(54, 57, 69);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Microsoft Sans Serif", 16F);
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(170, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(618, 400);
            listBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 67, 79);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(205, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 23);
            textBox1.TabIndex = 8;
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
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(EmojiButton);
            Name = "ChatForm";
            Text = "Form1";
            Load += ChatForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button EmojiButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button button1;
        private Button btnOpenVoiceChat;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button FileButton;
    }
}

namespace DiscordWinForm
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPictureURL = new TextBox();
            lblPicture = new Label();
            txtNickname = new TextBox();
            lblNickname = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtPictureURL
            // 
            txtPictureURL.Font = new Font("Segoe UI", 16F);
            txtPictureURL.Location = new Point(206, 253);
            txtPictureURL.Margin = new Padding(5, 6, 5, 6);
            txtPictureURL.Name = "txtPictureURL";
            txtPictureURL.Size = new Size(408, 36);
            txtPictureURL.TabIndex = 21;
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Font = new Font("Segoe UI", 16F);
            lblPicture.Location = new Point(67, 253);
            lblPicture.Margin = new Padding(9, 0, 9, 0);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(123, 30);
            lblPicture.TabIndex = 20;
            lblPicture.Text = "Picture URL";
            // 
            // txtNickname
            // 
            txtNickname.Font = new Font("Segoe UI", 16F);
            txtNickname.Location = new Point(206, 115);
            txtNickname.Margin = new Padding(5, 6, 5, 6);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(408, 36);
            txtNickname.TabIndex = 19;
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Font = new Font("Segoe UI", 16F);
            lblNickname.Location = new Point(67, 115);
            lblNickname.Margin = new Padding(9, 0, 9, 0);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(109, 30);
            lblNickname.TabIndex = 18;
            lblNickname.Text = "Nickname";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16F);
            txtPassword.Location = new Point(206, 185);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(408, 36);
            txtPassword.TabIndex = 17;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16F);
            lblPassword.Location = new Point(67, 191);
            lblPassword.Margin = new Padding(9, 0, 9, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 30);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 16F);
            txtUsername.Location = new Point(206, 49);
            txtUsername.Margin = new Padding(5, 6, 5, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(408, 36);
            txtUsername.TabIndex = 15;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 16F);
            lblUsername.Location = new Point(67, 49);
            lblUsername.Margin = new Padding(9, 0, 9, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 30);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "Username";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 16F);
            btnRegister.Location = new Point(318, 358);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 44);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtPictureURL);
            Controls.Add(lblPicture);
            Controls.Add(txtNickname);
            Controls.Add(lblNickname);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPictureURL;
        private Label lblPicture;
        private TextBox txtNickname;
        private Label lblNickname;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnRegister;
    }
}
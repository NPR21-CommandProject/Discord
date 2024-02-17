namespace DiscordWinForm
{
    partial class InitialForm
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
            btnSignIn = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Segoe UI", 16F);
            btnSignIn.Location = new Point(149, 256);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(115, 45);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 16F);
            btnRegister.Location = new Point(473, 256);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(115, 45);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnSignIn);
            Name = "InitialForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSignIn;
        private Button btnRegister;
    }
}

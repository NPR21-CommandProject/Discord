namespace DiscordWinForm
{
    partial class ds
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
            textBox1 = new TextBox();
            btn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(496, 27);
            textBox1.TabIndex = 0;
            // 
            // btn
            // 
            btn.Location = new Point(615, 156);
            btn.Name = "btn";
            btn.Size = new Size(161, 29);
            btn.TabIndex = 1;
            btn.Text = "Додати друга";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // ds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn);
            Controls.Add(textBox1);
            Name = "ds";
            Text = "ds";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn;
    }
}
namespace LocalEncryptedPasswordManager
{
    partial class Login
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
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            UsernameInput = new TextBox();
            UsernameLabel = new Label();
            BackBtn = new Button();
            LoginActivateBtn = new Button();
            SuspendLayout();
            // 
            // PasswordInput
            // 
            PasswordInput.Cursor = Cursors.IBeam;
            PasswordInput.Font = new Font("Lucida Console", 15F);
            PasswordInput.Location = new Point(640, 358);
            PasswordInput.MaxLength = 32;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(405, 27);
            PasswordInput.TabIndex = 7;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Lucida Console", 20F);
            PasswordLabel.Location = new Point(772, 316);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(140, 27);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameInput
            // 
            UsernameInput.Cursor = Cursors.IBeam;
            UsernameInput.Font = new Font("Lucida Console", 15F);
            UsernameInput.Location = new Point(640, 210);
            UsernameInput.MaxLength = 32;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(405, 27);
            UsernameInput.TabIndex = 5;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Lucida Console", 20F);
            UsernameLabel.Location = new Point(772, 168);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(140, 27);
            UsernameLabel.TabIndex = 4;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.Font = new Font("Lucida Console", 14F);
            BackBtn.ForeColor = SystemColors.InactiveBorder;
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(77, 77);
            BackBtn.TabIndex = 8;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // LoginActivateBtn
            // 
            LoginActivateBtn.BackColor = SystemColors.GradientActiveCaption;
            LoginActivateBtn.Cursor = Cursors.Hand;
            LoginActivateBtn.Location = new Point(667, 516);
            LoginActivateBtn.Name = "LoginActivateBtn";
            LoginActivateBtn.Size = new Size(350, 89);
            LoginActivateBtn.TabIndex = 9;
            LoginActivateBtn.Text = "Login";
            LoginActivateBtn.UseVisualStyleBackColor = false;
            LoginActivateBtn.Click += LoginActivateBtn_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1684, 761);
            ControlBox = false;
            Controls.Add(LoginActivateBtn);
            Controls.Add(BackBtn);
            Controls.Add(PasswordInput);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameInput);
            Controls.Add(UsernameLabel);
            Font = new Font("Lucida Console", 15F);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordInput;
        private Label PasswordLabel;
        private TextBox UsernameInput;
        private Label UsernameLabel;
        private Button BackBtn;
        private Button LoginActivateBtn;
    }
}
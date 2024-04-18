namespace LocalEncryptedPasswordManager
{
    partial class AddPwd
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
            BackBtn = new Button();
            UsernameInput = new TextBox();
            UsernameLabel = new Label();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            DescInput = new TextBox();
            DescLabel = new Label();
            SiteInput = new TextBox();
            SiteLabel = new Label();
            ShowPwdBtn = new CheckBox();
            AddPwdBtn = new Button();
            GenPwdBtn = new Button();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.ForeColor = SystemColors.InactiveBorder;
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(77, 77);
            BackBtn.TabIndex = 8;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // UsernameInput
            // 
            UsernameInput.Cursor = Cursors.IBeam;
            UsernameInput.Font = new Font("Lucida Console", 15F);
            UsernameInput.Location = new Point(310, 187);
            UsernameInput.MaxLength = 32;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(405, 27);
            UsernameInput.TabIndex = 10;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Lucida Console", 20F);
            UsernameLabel.Location = new Point(310, 147);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(140, 27);
            UsernameLabel.TabIndex = 9;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordInput
            // 
            PasswordInput.Cursor = Cursors.IBeam;
            PasswordInput.Font = new Font("Lucida Console", 15F);
            PasswordInput.Location = new Point(969, 187);
            PasswordInput.MaxLength = 32;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(405, 27);
            PasswordInput.TabIndex = 12;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Lucida Console", 20F);
            PasswordLabel.Location = new Point(969, 147);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(140, 27);
            PasswordLabel.TabIndex = 11;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescInput
            // 
            DescInput.Cursor = Cursors.IBeam;
            DescInput.Font = new Font("Lucida Console", 15F);
            DescInput.Location = new Point(969, 393);
            DescInput.MaxLength = 32;
            DescInput.Multiline = true;
            DescInput.Name = "DescInput";
            DescInput.Size = new Size(405, 143);
            DescInput.TabIndex = 14;
            // 
            // DescLabel
            // 
            DescLabel.AutoSize = true;
            DescLabel.Font = new Font("Lucida Console", 20F);
            DescLabel.Location = new Point(969, 353);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new Size(188, 27);
            DescLabel.TabIndex = 13;
            DescLabel.Text = "Description";
            DescLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiteInput
            // 
            SiteInput.Cursor = Cursors.IBeam;
            SiteInput.Font = new Font("Lucida Console", 15F);
            SiteInput.Location = new Point(310, 393);
            SiteInput.MaxLength = 32;
            SiteInput.Name = "SiteInput";
            SiteInput.Size = new Size(405, 27);
            SiteInput.TabIndex = 16;
            // 
            // SiteLabel
            // 
            SiteLabel.AutoSize = true;
            SiteLabel.Font = new Font("Lucida Console", 20F);
            SiteLabel.Location = new Point(310, 353);
            SiteLabel.Name = "SiteLabel";
            SiteLabel.Size = new Size(204, 27);
            SiteLabel.TabIndex = 15;
            SiteLabel.Text = "Site / Place";
            SiteLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowPwdBtn
            // 
            ShowPwdBtn.Appearance = Appearance.Button;
            ShowPwdBtn.Cursor = Cursors.Hand;
            ShowPwdBtn.ForeColor = SystemColors.ActiveCaptionText;
            ShowPwdBtn.Location = new Point(1380, 176);
            ShowPwdBtn.Name = "ShowPwdBtn";
            ShowPwdBtn.Size = new Size(67, 48);
            ShowPwdBtn.TabIndex = 17;
            ShowPwdBtn.Text = "Show";
            ShowPwdBtn.UseVisualStyleBackColor = true;
            ShowPwdBtn.CheckedChanged += UpdatePwdVisibility;
            // 
            // AddPwdBtn
            // 
            AddPwdBtn.BackColor = Color.Lime;
            AddPwdBtn.Cursor = Cursors.Hand;
            AddPwdBtn.Font = new Font("Lucida Console", 15F, FontStyle.Bold);
            AddPwdBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddPwdBtn.Location = new Point(713, 648);
            AddPwdBtn.Name = "AddPwdBtn";
            AddPwdBtn.Size = new Size(259, 60);
            AddPwdBtn.TabIndex = 18;
            AddPwdBtn.Text = "Add Password";
            AddPwdBtn.UseVisualStyleBackColor = false;
            AddPwdBtn.Click += AddPwdBtn_Click;
            // 
            // GenPwdBtn
            // 
            GenPwdBtn.BackColor = SystemColors.HotTrack;
            GenPwdBtn.ForeColor = Color.Gold;
            GenPwdBtn.Location = new Point(969, 231);
            GenPwdBtn.Name = "GenPwdBtn";
            GenPwdBtn.Size = new Size(309, 55);
            GenPwdBtn.TabIndex = 19;
            GenPwdBtn.Text = "Generate Password";
            GenPwdBtn.UseVisualStyleBackColor = false;
            GenPwdBtn.Click += GenPwdBtn_Click;
            // 
            // AddPwd
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1684, 761);
            ControlBox = false;
            Controls.Add(GenPwdBtn);
            Controls.Add(AddPwdBtn);
            Controls.Add(ShowPwdBtn);
            Controls.Add(SiteInput);
            Controls.Add(SiteLabel);
            Controls.Add(DescInput);
            Controls.Add(DescLabel);
            Controls.Add(PasswordInput);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameInput);
            Controls.Add(UsernameLabel);
            Controls.Add(BackBtn);
            Font = new Font("Lucida Console", 15F);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "AddPwd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPwd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private TextBox UsernameInput;
        private Label UsernameLabel;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private TextBox DescInput;
        private Label DescLabel;
        private TextBox SiteInput;
        private Label SiteLabel;
        private CheckBox ShowPwdBtn;
        private Button AddPwdBtn;
        private Button GenPwdBtn;
    }
}
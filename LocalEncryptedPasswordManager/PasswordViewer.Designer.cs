namespace LocalEncryptedPasswordManager
{
    partial class PasswordViewer
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
            SiteLabel = new Label();
            DescLabel = new Label();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            ShowPwdBtn = new CheckBox();
            CopyBtn = new Button();
            PasswordInput = new TextBox();
            SiteInput = new TextBox();
            DescInput = new TextBox();
            UsernameInput = new TextBox();
            EditBtn = new Button();
            DeleteBtn = new Button();
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
            BackBtn.TabIndex = 9;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // SiteLabel
            // 
            SiteLabel.AutoSize = true;
            SiteLabel.Font = new Font("Lucida Console", 20F);
            SiteLabel.Location = new Point(310, 331);
            SiteLabel.Name = "SiteLabel";
            SiteLabel.Size = new Size(204, 27);
            SiteLabel.TabIndex = 19;
            SiteLabel.Text = "Site / Place";
            SiteLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescLabel
            // 
            DescLabel.AutoSize = true;
            DescLabel.Font = new Font("Lucida Console", 20F);
            DescLabel.Location = new Point(969, 331);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new Size(188, 27);
            DescLabel.TabIndex = 18;
            DescLabel.Text = "Description";
            DescLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Lucida Console", 20F);
            PasswordLabel.Location = new Point(969, 125);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(140, 27);
            PasswordLabel.TabIndex = 17;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Lucida Console", 20F);
            UsernameLabel.Location = new Point(310, 125);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(140, 27);
            UsernameLabel.TabIndex = 16;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowPwdBtn
            // 
            ShowPwdBtn.Appearance = Appearance.Button;
            ShowPwdBtn.Cursor = Cursors.Hand;
            ShowPwdBtn.ForeColor = SystemColors.ActiveCaptionText;
            ShowPwdBtn.Location = new Point(969, 188);
            ShowPwdBtn.Name = "ShowPwdBtn";
            ShowPwdBtn.Size = new Size(73, 48);
            ShowPwdBtn.TabIndex = 20;
            ShowPwdBtn.Text = "Show";
            ShowPwdBtn.UseVisualStyleBackColor = true;
            ShowPwdBtn.CheckedChanged += ShowPwdBtn_CheckedChanged;
            // 
            // CopyBtn
            // 
            CopyBtn.Cursor = Cursors.Hand;
            CopyBtn.Location = new Point(1048, 188);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(73, 48);
            CopyBtn.TabIndex = 21;
            CopyBtn.Text = "Copy";
            CopyBtn.UseVisualStyleBackColor = true;
            CopyBtn.Click += CopyBtn_Click;
            // 
            // PasswordInput
            // 
            PasswordInput.Cursor = Cursors.IBeam;
            PasswordInput.Font = new Font("Lucida Console", 15F);
            PasswordInput.Location = new Point(969, 155);
            PasswordInput.MaxLength = 32;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.ReadOnly = true;
            PasswordInput.Size = new Size(405, 27);
            PasswordInput.TabIndex = 22;
            // 
            // SiteInput
            // 
            SiteInput.Cursor = Cursors.IBeam;
            SiteInput.Font = new Font("Lucida Console", 15F);
            SiteInput.Location = new Point(310, 361);
            SiteInput.MaxLength = 32;
            SiteInput.Name = "SiteInput";
            SiteInput.ReadOnly = true;
            SiteInput.Size = new Size(405, 27);
            SiteInput.TabIndex = 25;
            // 
            // DescInput
            // 
            DescInput.Cursor = Cursors.IBeam;
            DescInput.Font = new Font("Lucida Console", 15F);
            DescInput.Location = new Point(969, 361);
            DescInput.MaxLength = 32;
            DescInput.Multiline = true;
            DescInput.Name = "DescInput";
            DescInput.ReadOnly = true;
            DescInput.Size = new Size(405, 143);
            DescInput.TabIndex = 24;
            // 
            // UsernameInput
            // 
            UsernameInput.Cursor = Cursors.IBeam;
            UsernameInput.Font = new Font("Lucida Console", 15F);
            UsernameInput.Location = new Point(310, 155);
            UsernameInput.MaxLength = 32;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.ReadOnly = true;
            UsernameInput.Size = new Size(405, 27);
            UsernameInput.TabIndex = 23;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.MediumOrchid;
            EditBtn.Cursor = Cursors.Hand;
            EditBtn.ForeColor = SystemColors.InactiveBorder;
            EditBtn.Location = new Point(310, 632);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(446, 77);
            EditBtn.TabIndex = 26;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.ForeColor = SystemColors.InactiveBorder;
            DeleteBtn.Location = new Point(928, 632);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(446, 77);
            DeleteBtn.TabIndex = 27;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // PasswordViewer
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(1684, 761);
            ControlBox = false;
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SiteInput);
            Controls.Add(DescInput);
            Controls.Add(UsernameInput);
            Controls.Add(PasswordInput);
            Controls.Add(CopyBtn);
            Controls.Add(ShowPwdBtn);
            Controls.Add(SiteLabel);
            Controls.Add(DescLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(BackBtn);
            Font = new Font("Comic Sans MS", 15F);
            Name = "PasswordViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordViewer";
            Activated += PasswordViewer_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Label SiteLabel;
        private Label DescLabel;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private CheckBox ShowPwdBtn;
        private Button CopyBtn;
        private TextBox PasswordInput;
        private TextBox SiteInput;
        private TextBox DescInput;
        private TextBox UsernameInput;
        private Button EditBtn;
        private Button DeleteBtn;
    }
}
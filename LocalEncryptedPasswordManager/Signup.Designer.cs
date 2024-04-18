namespace LocalEncryptedPasswordManager
{
    partial class Signup
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
            UsernameLabel = new Label();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            ConfirmPasswordInput = new TextBox();
            label1 = new Label();
            SignupActivateBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Lucida Console", 20F);
            UsernameLabel.Location = new Point(772, 89);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(140, 27);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameInput
            // 
            UsernameInput.Font = new Font("Lucida Console", 15F);
            UsernameInput.Location = new Point(640, 131);
            UsernameInput.MaxLength = 32;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(405, 27);
            UsernameInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Lucida Console", 15F);
            PasswordInput.Location = new Point(640, 279);
            PasswordInput.MaxLength = 32;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(405, 27);
            PasswordInput.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Lucida Console", 20F);
            PasswordLabel.Location = new Point(772, 237);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(140, 27);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConfirmPasswordInput
            // 
            ConfirmPasswordInput.Font = new Font("Lucida Console", 15F);
            ConfirmPasswordInput.Location = new Point(640, 427);
            ConfirmPasswordInput.MaxLength = 32;
            ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            ConfirmPasswordInput.PasswordChar = '*';
            ConfirmPasswordInput.Size = new Size(405, 27);
            ConfirmPasswordInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 20F);
            label1.Location = new Point(708, 385);
            label1.Name = "label1";
            label1.Size = new Size(268, 27);
            label1.TabIndex = 4;
            label1.Text = "Confirm Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignupActivateBtn
            // 
            SignupActivateBtn.BackColor = SystemColors.GradientActiveCaption;
            SignupActivateBtn.ForeColor = SystemColors.InactiveCaptionText;
            SignupActivateBtn.Location = new Point(667, 611);
            SignupActivateBtn.Name = "SignupActivateBtn";
            SignupActivateBtn.Size = new Size(350, 89);
            SignupActivateBtn.TabIndex = 6;
            SignupActivateBtn.Text = "Signup";
            SignupActivateBtn.UseVisualStyleBackColor = false;
            SignupActivateBtn.Click += SignupActivateBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.ForeColor = SystemColors.InactiveBorder;
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(77, 77);
            BackBtn.TabIndex = 7;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // Signup
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1684, 761);
            ControlBox = false;
            Controls.Add(BackBtn);
            Controls.Add(SignupActivateBtn);
            Controls.Add(ConfirmPasswordInput);
            Controls.Add(label1);
            Controls.Add(PasswordInput);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameInput);
            Controls.Add(UsernameLabel);
            Font = new Font("Lucida Console", 14F);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private TextBox ConfirmPasswordInput;
        private Label label1;
        private Button SignupActivateBtn;
        private Button BackBtn;
    }
}
namespace LocalEncryptedPasswordManager
{
    partial class LoginSignup
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
            LoginBtn = new Button();
            SignupBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.HotTrack;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Lucida Console", 20F);
            LoginBtn.ForeColor = SystemColors.ButtonFace;
            LoginBtn.Location = new Point(640, 122);
            LoginBtn.Margin = new Padding(3, 2, 3, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(400, 100);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Log in";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = SystemColors.HotTrack;
            SignupBtn.Cursor = Cursors.Hand;
            SignupBtn.Font = new Font("Lucida Console", 20F);
            SignupBtn.ForeColor = SystemColors.ButtonFace;
            SignupBtn.Location = new Point(640, 330);
            SignupBtn.Margin = new Padding(3, 2, 3, 2);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(400, 100);
            SignupBtn.TabIndex = 1;
            SignupBtn.Text = "Sign Up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = SystemColors.HotTrack;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.Font = new Font("Lucida Console", 20F);
            ExitBtn.ForeColor = SystemColors.ButtonFace;
            ExitBtn.Location = new Point(640, 538);
            ExitBtn.Margin = new Padding(3, 2, 3, 2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(400, 100);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // LoginSignup
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1684, 761);
            ControlBox = false;
            Controls.Add(ExitBtn);
            Controls.Add(SignupBtn);
            Controls.Add(LoginBtn);
            Font = new Font("Lucida Console", 10F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login / Signup";
            ResumeLayout(false);
        }

        #endregion

        private Button LoginBtn;
        private Button SignupBtn;
        private Button ExitBtn;
    }
}

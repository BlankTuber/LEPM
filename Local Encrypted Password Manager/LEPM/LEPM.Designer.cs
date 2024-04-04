namespace LEPM
{
    partial class LEPM
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
            HomePanel = new Panel();
            signUpBtn = new Button();
            logInBtn = new Button();
            title = new Label();
            HomePanel.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(signUpBtn);
            HomePanel.Controls.Add(logInBtn);
            HomePanel.Controls.Add(title);
            HomePanel.Location = new Point(-9, -24);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1920, 1080);
            HomePanel.TabIndex = 0;
            HomePanel.Visible = false;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.Lime;
            signUpBtn.Cursor = Cursors.Hand;
            signUpBtn.FlatAppearance.BorderColor = Color.Green;
            signUpBtn.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            signUpBtn.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("SimSun", 30F, FontStyle.Bold);
            signUpBtn.ForeColor = Color.Black;
            signUpBtn.Location = new Point(605, 747);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(710, 132);
            signUpBtn.TabIndex = 5;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.Lime;
            logInBtn.Cursor = Cursors.Hand;
            logInBtn.FlatAppearance.BorderColor = Color.Green;
            logInBtn.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            logInBtn.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.Font = new Font("SimSun", 30F, FontStyle.Bold);
            logInBtn.ForeColor = Color.Black;
            logInBtn.Location = new Point(605, 458);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(710, 132);
            logInBtn.TabIndex = 4;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Lucida Console", 45F, FontStyle.Bold);
            title.ForeColor = Color.Lime;
            title.Location = new Point(208, 201);
            title.Name = "title";
            title.Size = new Size(1504, 75);
            title.TabIndex = 3;
            title.Text = "Local Encrypted Password Manager";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1902, 1033);
            Controls.Add(HomePanel);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LEPM";
            WindowState = FormWindowState.Maximized;
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HomePanel;
        private Button signUpBtn;
        private Button logInBtn;
        private Label title;
    }
}

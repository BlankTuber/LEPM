namespace Local_Encrypted_Password_Manager
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LogInBtn = new Button();
            SignUpBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 60F, FontStyle.Bold);
            label1.Location = new Point(604, 36);
            label1.Name = "label1";
            label1.Size = new Size(713, 100);
            label1.TabIndex = 0;
            label1.Text = "LEPM - Home";
            // 
            // LogInBtn
            // 
            LogInBtn.BackColor = Color.Lime;
            LogInBtn.Cursor = Cursors.Hand;
            LogInBtn.FlatAppearance.BorderColor = Color.White;
            LogInBtn.FlatAppearance.BorderSize = 3;
            LogInBtn.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            LogInBtn.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            LogInBtn.FlatStyle = FlatStyle.Flat;
            LogInBtn.Font = new Font("SimSun", 50F, FontStyle.Bold);
            LogInBtn.ForeColor = Color.Black;
            LogInBtn.Location = new Point(635, 275);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(650, 142);
            LogInBtn.TabIndex = 1;
            LogInBtn.Text = "Login";
            LogInBtn.UseVisualStyleBackColor = false;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.Lime;
            SignUpBtn.Cursor = Cursors.Hand;
            SignUpBtn.FlatAppearance.BorderColor = Color.White;
            SignUpBtn.FlatAppearance.BorderSize = 3;
            SignUpBtn.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            SignUpBtn.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("SimSun", 50F, FontStyle.Bold);
            SignUpBtn.ForeColor = Color.Black;
            SignUpBtn.Location = new Point(635, 485);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(650, 142);
            SignUpBtn.TabIndex = 2;
            SignUpBtn.Text = "Signup";
            SignUpBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderColor = Color.Cyan;
            ExitBtn.FlatAppearance.BorderSize = 3;
            ExitBtn.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("SimSun", 50F, FontStyle.Bold);
            ExitBtn.ForeColor = Color.Black;
            ExitBtn.Location = new Point(635, 858);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(650, 142);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.Black;
            Controls.Add(ExitBtn);
            Controls.Add(SignUpBtn);
            Controls.Add(LogInBtn);
            Controls.Add(label1);
            Font = new Font("SimSun", 30F, FontStyle.Bold);
            ForeColor = Color.Lime;
            Margin = new Padding(9, 7, 9, 7);
            Name = "Home";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LogInBtn;
        private Button SignUpBtn;
        private Button ExitBtn;
    }
}

namespace Local_Encrypted_Password_Manager
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
            home1 = new Home();
            SuspendLayout();
            // 
            // home1
            // 
            home1.AutoSize = true;
            home1.BackColor = Color.Black;
            home1.Font = new Font("SimSun", 30F, FontStyle.Bold);
            home1.ForeColor = Color.Lime;
            home1.Location = new Point(0, 0);
            home1.Margin = new Padding(9, 7, 9, 7);
            home1.Name = "home1";
            home1.Size = new Size(1920, 1080);
            home1.TabIndex = 0;
            // 
            // LEPM
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(1902, 1033);
            ControlBox = false;
            Controls.Add(home1);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LEPM";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Encrypted Password Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Home home1;
    }
}

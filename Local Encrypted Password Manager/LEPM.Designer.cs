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
            mainPanel = new Panel();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1478, 699);
            mainPanel.TabIndex = 0;
            // 
            // LEPM
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(1478, 699);
            ControlBox = false;
            Controls.Add(mainPanel);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LEPM";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Encrypted Password Manager";
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
    }
}

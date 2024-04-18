namespace LocalEncryptedPasswordManager
{
    partial class MainMenu
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
            MainExitBtn = new Button();
            SuspendLayout();
            // 
            // MainExitBtn
            // 
            MainExitBtn.Font = new Font("Segoe UI", 20F);
            MainExitBtn.Location = new Point(564, 244);
            MainExitBtn.Name = "MainExitBtn";
            MainExitBtn.Size = new Size(557, 273);
            MainExitBtn.TabIndex = 0;
            MainExitBtn.Text = "Exit";
            MainExitBtn.UseVisualStyleBackColor = true;
            MainExitBtn.Click += MainExitBtn_Click;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1684, 761);
            Controls.Add(MainExitBtn);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button MainExitBtn;
    }
}
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
            ExportPwdBtn = new Button();
            AddPwdBtn = new Button();
            buttonsPanel = new Panel();
            btnPrevious = new Button();
            btnNext = new Button();
            PageLabel = new Label();
            SuspendLayout();
            // 
            // MainExitBtn
            // 
            MainExitBtn.BackColor = Color.Lime;
            MainExitBtn.Cursor = Cursors.Hand;
            MainExitBtn.Font = new Font("Lucida Console", 15F, FontStyle.Bold);
            MainExitBtn.Location = new Point(51, 689);
            MainExitBtn.Name = "MainExitBtn";
            MainExitBtn.Size = new Size(259, 60);
            MainExitBtn.TabIndex = 0;
            MainExitBtn.Text = "Exit";
            MainExitBtn.UseVisualStyleBackColor = false;
            MainExitBtn.Click += MainExitBtn_Click;
            // 
            // ExportPwdBtn
            // 
            ExportPwdBtn.BackColor = Color.Lime;
            ExportPwdBtn.Cursor = Cursors.Hand;
            ExportPwdBtn.Font = new Font("Lucida Console", 15F, FontStyle.Bold);
            ExportPwdBtn.Location = new Point(1374, 689);
            ExportPwdBtn.Name = "ExportPwdBtn";
            ExportPwdBtn.Size = new Size(259, 60);
            ExportPwdBtn.TabIndex = 1;
            ExportPwdBtn.Text = "Export Passwords";
            ExportPwdBtn.UseVisualStyleBackColor = false;
            ExportPwdBtn.Click += ExportPwdBtn_Click;
            // 
            // AddPwdBtn
            // 
            AddPwdBtn.BackColor = Color.Lime;
            AddPwdBtn.Cursor = Cursors.Hand;
            AddPwdBtn.Font = new Font("Lucida Console", 15F, FontStyle.Bold);
            AddPwdBtn.Location = new Point(713, 689);
            AddPwdBtn.Name = "AddPwdBtn";
            AddPwdBtn.Size = new Size(259, 60);
            AddPwdBtn.TabIndex = 2;
            AddPwdBtn.Text = "Add Password";
            AddPwdBtn.UseVisualStyleBackColor = false;
            AddPwdBtn.Click += AddPwdBtn_Click;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Location = new Point(224, 102);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(1237, 556);
            buttonsPanel.TabIndex = 3;
            // 
            // btnPrevious
            // 
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.Font = new Font("Corbel", 25F, FontStyle.Bold);
            btnPrevious.Location = new Point(51, 291);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(100, 100);
            btnPrevious.TabIndex = 4;
            btnPrevious.Text = "<-";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("Corbel", 25F, FontStyle.Bold);
            btnNext.Location = new Point(1533, 291);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 100);
            btnNext.TabIndex = 5;
            btnNext.Text = "->";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // PageLabel
            // 
            PageLabel.ForeColor = SystemColors.ButtonFace;
            PageLabel.Location = new Point(802, 35);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(81, 45);
            PageLabel.TabIndex = 6;
            PageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(1684, 761);
            ControlBox = false;
            Controls.Add(PageLabel);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(buttonsPanel);
            Controls.Add(AddPwdBtn);
            Controls.Add(ExportPwdBtn);
            Controls.Add(MainExitBtn);
            Font = new Font("Lucida Console", 15F);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            Activated += MainMenu_Activated;
            ResumeLayout(false);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button MainExitBtn;
        private Button ExportPwdBtn;
        private Button AddPwdBtn;
        private Panel buttonsPanel;
        private Button btnPrevious;
        private Button btnNext;
        private Label PageLabel;
    }
}
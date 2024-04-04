namespace Local_Encrypted_Password_Manager.UserControls
{
    partial class ExitButton
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
            ExitBtn = new Button();
            SuspendLayout();
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
            ExitBtn.Location = new Point(0, 0);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(650, 142);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ExitButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(ExitBtn);
            Name = "ExitButton";
            Size = new Size(650, 142);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitBtn;
    }
}

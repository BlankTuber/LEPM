// Home.cs:
using System;
using System.Windows.Forms;

namespace Local_Encrypted_Password_Manager
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            UserControl loginControl = new Local_Encrypted_Password_Manager.UserControls.Login(); // Assume this is your actual login UserControl
            var mainForm = this.FindForm() as LEPM; // Cast the found form to LEPM
            mainForm?.LoadUserControl(loginControl); // Use ?. to guard against null
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            UserControl signUpControl = new Local_Encrypted_Password_Manager.UserControls.SignUp(); // Assume this is your actual sign up UserControl
            var mainForm = this.FindForm() as LEPM; // Cast the found form to LEPM
            mainForm?.LoadUserControl(signUpControl); // Use ?. to guard against null
        }
    }
}
namespace LocalEncryptedPasswordManager
{
    public partial class LoginSignup : Form
    {
        public LoginSignup()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Program.ShowLoginForm();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            Program.ShowSignupForm();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

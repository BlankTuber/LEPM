namespace LocalEncryptedPasswordManager
{
    public static class GlobalVariables
    {
        public static string key = "";
        public static string username = "";
        public static string filePath = "";
    }

    internal static class Program
    {
        public static Form LoginSignupForm;
        public static Form SignupForm;
        public static Form LoginForm;
        public static Form AddPwdForm;

        public static ApplicationContext AppContext;


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            LoginSignupForm = new LoginSignup();
            SignupForm = new Signup();
            LoginForm = new Login();
            AddPwdForm = new AddPwd();

            AppContext = new ApplicationContext();
            AppContext.MainForm = LoginSignupForm;

            Application.Run(AppContext);
        }

        public static void ShowStartForm()
        {
            if (LoginSignupForm == null || LoginSignupForm.IsDisposed)
            {
                LoginSignupForm = new LoginSignup();
            }
            LoginSignupForm.Show();
            SignupForm.Hide();
            LoginForm.Hide();
        }

        public static void ShowSignupForm()
        {
            if (SignupForm == null || SignupForm.IsDisposed)
            {
                SignupForm = new Signup();
            }
            SignupForm.Show();
            LoginSignupForm.Hide();
        }

        public static void ShowLoginForm()
        {
            if (LoginForm == null || LoginForm.IsDisposed)
            {
                LoginForm = new Login();
            }
            LoginForm.Show();
            LoginSignupForm.Hide();
        }

        public static void ShowAddPwdForm()
        {
            if (AddPwdForm == null || AddPwdForm.IsDisposed)
            {
                AddPwdForm = new AddPwd();
            }
            AddPwdForm.Show();
            AddPwd.ClearAllContent();
        }

        public static void HideAddPwdForm()
        {
            AddPwdForm.Hide();
        }

        public static void LoginComplete()
        {
            MainMenu MainForm = new MainMenu();
            AppContext.MainForm = MainForm;

            MainForm.Show();

            MainForm.LoadPasswords();
            MainForm.getMaxPages();

            LoginSignupForm.Close();
            SignupForm.Close();
            LoginForm.Close();
        }
    }
}
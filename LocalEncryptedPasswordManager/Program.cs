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
        public static Form MainForm;

        public static ApplicationContext AppContext;


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            LoginSignupForm = new LoginSignup();
            SignupForm = new Signup();
            LoginForm = new Login();
            MainForm = new MainMenu();

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

        public static void LoginComplete()
        {
            if (MainForm == null || MainForm.IsDisposed)
            {
                MainForm = new MainMenu();
            }
            AppContext.MainForm = MainForm;

            MainForm.Show();
            LoginSignupForm.Close();
            SignupForm.Close();
            LoginForm.Close();
        }
    }
}
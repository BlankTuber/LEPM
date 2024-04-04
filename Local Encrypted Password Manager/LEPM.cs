namespace Local_Encrypted_Password_Manager
{
    public partial class LEPM : Form
    {
        public LEPM()
        {
            InitializeComponent();
            LoadUserControl(new Home());
        }

        public void LoadUserControl(UserControl? userControl)
        {
            if (userControl != null)
            {
                mainPanel.Controls.Clear(); // Clear the current control(s)
                userControl.Dock = DockStyle.Fill; // Make it fill the space
                mainPanel.Controls.Add(userControl); // Add the new control
            }
        }
    }
}

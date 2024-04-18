using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace LocalEncryptedPasswordManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginActivateBtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UsernameInput.Text;
            string passwordInput = PasswordInput.Text;

            if (string.IsNullOrEmpty(usernameInput))
            {
                MessageBox.Show("No username!");
                return;
            }

            if (string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("No password!");
                return;
            }

            string fileName = "user.txt";
            string fileFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, usernameInput);


            if (!Directory.Exists(fileFolderPath))
            {
                MessageBox.Show("User doesn't exist!");
                return;
            }

            string filePath = Path.Combine(fileFolderPath, fileName);

            if (!File.Exists(filePath))
            {
                MessageBox.Show("User doesn't exist!");
                return;
            }

            LoginCheckAndGo.lcag(usernameInput, passwordInput, filePath);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Program.ShowStartForm();
        }
    }
}

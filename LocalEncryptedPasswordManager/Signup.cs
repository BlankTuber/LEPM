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

namespace LocalEncryptedPasswordManager
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void SignupActivateBtn_Click(object sender, EventArgs e)
        {
            string usrNam = UsernameInput.Text;
            string pwd = PasswordInput.Text;
            string confPwd = ConfirmPasswordInput.Text;

            if (string.IsNullOrWhiteSpace(usrNam))
            {
                MessageBox.Show("No username input");
                return;
            }

            if (usrNam.Length < 3)
            {
                MessageBox.Show("Username too short");
                return;
            }

            if (string.IsNullOrWhiteSpace(pwd) || string.IsNullOrWhiteSpace(confPwd))
            {
                MessageBox.Show("No password input");
                return;
            }

            if (pwd.Length < 5)
            {
                MessageBox.Show("Password too short");
                return;
            }

            if (pwd != confPwd)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            SignupCheckAndGo.scag(usrNam, pwd);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Program.ShowStartForm();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalEncryptedPasswordManager
{
    public partial class AddPwd : Form
    {
        public AddPwd()
        {
            InitializeComponent();
        }

        public static void ClearAllContent()
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Program.HideAddPwdForm();
        }

        private void UpdatePwdVisibility(object sender, EventArgs e)
        {
            if (ShowPwdBtn.Checked)
            {
                PasswordInput.PasswordChar = '\0';
                ShowPwdBtn.Text = "Hide";
            }
            else
            {
                PasswordInput.PasswordChar = '*';
                ShowPwdBtn.Text = "Show";
            }
        }

        private void AddPwdBtn_Click(object sender, EventArgs e)
        {
            string usrNam = UsernameInput.Text;
            string pwd = PasswordInput.Text;
            string site = SiteInput.Text;
            string desc = DescInput.Text;
        }
    }
}

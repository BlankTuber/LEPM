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

        public static string[]? loadedItems;
        public AddPwd()
        {
            InitializeComponent();
        }

        private void ClearAllContent()
        {
            UsernameInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
            SiteInput.Text = string.Empty;
            DescInput.Text = string.Empty;
            ShowPwdBtn.Text = "Show";
            ShowPwdBtn.Checked = false;
            Program.HideAddPwdForm();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ClearAllContent();
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

            if (string.IsNullOrWhiteSpace(usrNam))
            {
                MessageBox.Show("No username!");
                return;
            }
            if (string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("No password!");
                return;
            }
            if (string.IsNullOrWhiteSpace(site))
            {
                MessageBox.Show("No site / place!");
                return;
            }
            if (string.IsNullOrWhiteSpace(desc))
            {
                desc = "No description!";
            }

            if (desc.Length > 100)
            {
                MessageBox.Show("Description is too long!");
                return;
            }

            string newDesc = desc.Replace("\n", "\t");

            string invalidCharsPattern = @"[<>:""/\\|?*]|[\x00-\x1F]";
            string safeUsrNam = System.Text.RegularExpressions.Regex.Replace(usrNam, invalidCharsPattern, "[I]");
            string safeSite = System.Text.RegularExpressions.Regex.Replace(site, invalidCharsPattern, "[I]");



            Passwords.SavePassword(safeUsrNam, pwd, safeSite, newDesc);
            ClearAllContent();

        }

        private void GenPwdBtn_Click(object sender, EventArgs e)
        {
            string pwd = Cryption.PasswordGenerator();
            if (string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Something went wrong!");
                return;
            }
            PasswordInput.Text = pwd;
        }

        public static void AddPwd_Loader(string[]? items = null)
        {
            if (items != null)
            {
                loadedItems = items;
            }
        }

        private void AddPwd_Activated(object sender, EventArgs e)
        {
            if (loadedItems != null && loadedItems.Any())
            {
                string username = loadedItems[0];
                string password = loadedItems[1];
                string site = loadedItems[2];
                string desc = loadedItems[3];

                UsernameInput.Text = username;
                PasswordInput.Text = password;
                SiteInput.Text = site;
                DescInput.Text = desc;

                loadedItems = null;
            }
        }
    }
}

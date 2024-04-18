using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LocalEncryptedPasswordManager
{
    public partial class PasswordViewer : Form
    {
        public static string[]? loadedItems;

        public PasswordViewer()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Program.HidePwdViewerForm();
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordInput.Text);
            MessageBox.Show("Copied password!");
        }

        private void ShowPwdBtn_CheckedChanged(object sender, EventArgs e)
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

        private void PasswordViewer_Activated(object sender, EventArgs e)
        {
            if (loadedItems != null && loadedItems.Length == 5)
            {
                string username = loadedItems[0];
                string password = loadedItems[1];
                string site = loadedItems[2];
                string description = loadedItems[3];
                string newDesc = description.Replace("\t", "\n");


                UsernameInput.Text = username;
                PasswordInput.Text = password;
                SiteInput.Text = site;
                DescInput.Text = newDesc;
            }
            else
            {
                MessageBox.Show("File is corrupted...");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(GlobalVariables.filePath, loadedItems[4]);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Program.HidePwdViewerForm();

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotYetADDED!");
        }
    }
}

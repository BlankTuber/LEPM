using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using System.IO.Compression;

namespace LocalEncryptedPasswordManager
{
    public partial class MainMenu : Form
    {
        private int currentIndex = 0;
        private int currentPage = 1;
        private const int maxButtons = 12;
        private int maxPages = 1;

        public MainMenu()
        {
            InitializeComponent();
            UpdateNavigationButtons();
        }

        private void MainExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LoadPasswords()
        {
            PageLabel.Text = $"{currentPage}/{maxPages}";
            buttonsPanel.Controls.Clear();

            string[] files = Directory.GetFiles(GlobalVariables.filePath).Skip(currentIndex).Take(maxButtons).OrderBy(f => f).ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                int margin = 5;
                int buttonWidth = (buttonsPanel.Width - (4 * margin)) / 3;
                int buttonHeight = (buttonsPanel.Height - (5 * margin)) / 4;

                Button btn = new Button
                {
                    Text = Path.GetFileNameWithoutExtension(files[i]),
                    Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                    Location = new System.Drawing.Point(
                        (i % 3) * (buttonWidth + margin) + margin,
                        (i / 3) * (buttonHeight + margin) + margin),
                    BackColor = Color.Yellow,
                    Cursor = Cursors.Hand
                };

                btn.Click += FileButton_Click;

                buttonsPanel.Controls.Add(btn);
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                string file = $"{btn.Text}.txt";
                Program.LoadPwdViewerForm(file);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage += 1;
            currentIndex += maxButtons;
            LoadPasswords();
            UpdateNavigationButtons();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentPage -= 1;
            currentIndex = Math.Max(0, currentIndex - maxButtons);
            LoadPasswords();
            UpdateNavigationButtons();
        }

        public void getMaxPages()
        {
            int totalFiles = Directory.GetFiles(GlobalVariables.filePath).Length;
            int filesPerPage = 12;
            maxPages = (totalFiles + filesPerPage - 1) / filesPerPage;
        }

        private void UpdateNavigationButtons()
        {
            btnPrevious.Enabled = currentIndex > 0;
            btnNext.Enabled = Directory.GetFiles(GlobalVariables.filePath).Length > currentIndex + maxButtons;
        }

        private void AddPwdBtn_Click(object sender, EventArgs e)
        {
            Program.ShowAddPwdForm();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            LoadPasswords();
            UpdateNavigationButtons();
            getMaxPages();
        }

        private void ExportPwdBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will make a zipped folder with all your information, and put it in your downloads folder. Do you wish to proceed?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                string downloadsPath = Path.Combine(userProfilePath, "Downloads");

                if (!Directory.Exists(downloadsPath))
                {
                    MessageBox.Show("The Downloads folder does not exist. Please check the path and try again.");
                    return;
                }

                string zipFileName = "MyPasswordsBackup.zip";
                string destinationZipFilePath = Path.Combine(downloadsPath, zipFileName);

                CreateZipFromDirectory(AppDomain.CurrentDomain.BaseDirectory, destinationZipFilePath);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelling...");
            }
        }

        public static void CreateZipFromDirectory(string sourceDirectory, string destinationZipFilePath)
        {
            if (!Directory.Exists(sourceDirectory))
            {
                MessageBox.Show("The specified directory does not exist.");
                return;
            }

            try
            {
                if (File.Exists(destinationZipFilePath))
                {
                    File.Delete(destinationZipFilePath);
                }

                ZipFile.CreateFromDirectory(sourceDirectory, destinationZipFilePath);

                MessageBox.Show($"Directory {sourceDirectory} zipped to {destinationZipFilePath}. Unzip it to use it as normal.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the zip file: {ex.Message}");
            }
        }

    }
}

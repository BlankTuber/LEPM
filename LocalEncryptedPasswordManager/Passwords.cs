using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalEncryptedPasswordManager
{
    internal class Passwords
    {
        public static void SavePassword(string username, string password, string site, string desc)
        {
            string fileName = $"{site}.txt";
            string filePath = Path.Combine(GlobalVariables.filePath, fileName);

            if (File.Exists(filePath))
            {
                fileName = $"{site}_{username}.txt";
                filePath = Path.Combine(GlobalVariables.filePath, fileName);
            }

            string[] dataLines = { username, password, site, desc, fileName };
            for (int i = 0; i < dataLines.Length; i++)
            {
                dataLines[i] = Cryption.Encrypt(dataLines[i], GlobalVariables.key);
            }

            File.WriteAllLines(filePath, dataLines);
        }

        public static string[] LoadPassword(string file)
        {
            string filePath = Path.Combine(GlobalVariables.filePath, file);

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The specified file was not found.", filePath);
                return new string[0];
            }

            string[] encryptedDataLines = File.ReadAllLines(filePath);

            for (int i = 0; i < encryptedDataLines.Length; i++)
            {
                encryptedDataLines[i] = Cryption.Decrypt(encryptedDataLines[i], GlobalVariables.key);
            }

            return encryptedDataLines;
        }

    }
}

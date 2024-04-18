using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace LocalEncryptedPasswordManager
{
    internal class LoginCheckAndGo
    {
        public static void lcag(string username, string password, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 3 )
            {
                MessageBox.Show($"Invalid user data file! Please delete it or fix it manually.\nLocated at: {filePath}");
                Program.ShowStartForm();
                return;
            }

            string usrEncrypted = lines[0];
            string saltBase64 = lines[2];


            string salt = saltBase64;
            byte[] saltBytes = Convert.FromBase64String(salt);

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] derivedKeyBytes;
            using (SHA256 sha256 = SHA256.Create())
            {
                derivedKeyBytes = sha256.ComputeHash(passwordBytes.Concat(saltBytes).ToArray());
            }
            string derivedKey = Convert.ToBase64String(derivedKeyBytes);


            string decryptedUsername = Cryption.Decrypt(usrEncrypted, derivedKey);

            if (decryptedUsername != username)
            {
                MessageBox.Show("Your password was incorrect!");
                Program.ShowStartForm();
                return;
            }
            else
            {
                GlobalVariables.key = derivedKey;
                Program.LoginComplete();
                return;
            }
        }
    }
}

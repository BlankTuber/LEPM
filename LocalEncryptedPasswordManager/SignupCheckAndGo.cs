using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace LocalEncryptedPasswordManager
{
    internal class SignupCheckAndGo
    {
        public static void scag(string userName, string password)
        {
            string fileName =  $"{userName}.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (File.Exists(filePath))
            {
                MessageBox.Show("User already exists!");
                Program.ShowStartForm();
                return;
            }

            string salt = Cryption.PasswordGenerator();
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] derivedKeyBytes;
            using (SHA256 sha256 = SHA256.Create())
            {
                derivedKeyBytes = sha256.ComputeHash(passwordBytes.Concat(saltBytes).ToArray());
            }
            string derivedKey = Convert.ToBase64String(derivedKeyBytes);


            string usrEncrypted = Cryption.Encrypt(userName, derivedKey);
            string pwdEncrypted = Cryption.Encrypt(password, derivedKey);

            string fileInfo = $"{usrEncrypted}\n{pwdEncrypted}\n{Convert.ToBase64String(saltBytes)}";

            File.WriteAllText(filePath, fileInfo);
            GlobalVariables.key = derivedKey;
            Program.LoginComplete();
            return;
        }
    }
}

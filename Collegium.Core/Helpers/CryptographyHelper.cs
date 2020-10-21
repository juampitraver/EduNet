using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TP3.Core.Helpers
{
    public static class CryptographyHelper
    {

        // set permutations
        private const String strPermutation = "nuyvgyxaztv";
        private const Int32 bytePermutation1 = 0x06;
        private const Int32 bytePermutation2 = 0x81;
        private const Int32 bytePermutation3 = 0x32;
        private const Int32 bytePermutation4 = 0x51;

        // encoding
        public static string Encrypt(string password)
        {
            string passEncrypted = Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(password)));
            return passEncrypted;
        }


        // decoding
        public static string Decrypt(string password)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(password)));
        }

        // encrypt
        private static byte[] Encrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(strPermutation,
            new byte[] { bytePermutation1,
                         bytePermutation2,
                         bytePermutation3,
                         bytePermutation4
            });

            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateEncryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }

        // decrypt
        private static byte[] Decrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(strPermutation,
            new byte[] { bytePermutation1,
                         bytePermutation2,
                         bytePermutation3,
                         bytePermutation4
            });

            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateDecryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }
    }
}

using System;
using System.IO;
using System.Security.Cryptography;

namespace RijndaelAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText =
                "Lorem ipsum dolor sit amet...";
            using (var rm = new RijndaelManaged())
            {
                Console.WriteLine(
                    "Before Encryption: {0}",
                     plainText);
                byte[] encryptedBytes =
                    Encrypt(plainText,
                    rm.Key, rm.IV);
                string decryptedText =
                    Decrypt(encryptedBytes,
                    rm.Key, rm.IV);
                Console.WriteLine(
                    "After Decryption : {0}",
                    decryptedText);
            }
        }

        private static byte[] Encrypt(
            string plainText, byte[] key,
            byte[] iv)
        {
            byte[] encryptedBytes;

            using (var rm = new RijndaelManaged())
            {
                rm.Key = key;
                rm.IV = iv;

                ICryptoTransform encryptor =
                    rm.CreateEncryptor(
                    rm.Key, rm.IV);
                using (MemoryStream ms =
                    new MemoryStream())
                {
                    using (CryptoStream cs =
                        new CryptoStream(
                        ms, encryptor,
                        CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw =
                            new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        encryptedBytes =
                              ms.ToArray();
                    }
                }
            }
            return encryptedBytes;
        }

        private static string Decrypt(
            byte[] encryptedBytes, byte[] key,
            byte[] iv)
        {
            string decryptedText = null;
            using (var rm = new RijndaelManaged())
            {
                rm.Key = key;
                rm.IV = iv;

                ICryptoTransform decryptor =
                    rm.CreateDecryptor(rm.Key,
                    rm.IV);
                using (MemoryStream ms =
                 new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream cs =
                        new CryptoStream(
                        ms, decryptor,
                        CryptoStreamMode.Read))
                    {
                        using (StreamReader sr =
                            new StreamReader(cs))
                        {
                            decryptedText =
                             sr.ReadToEnd();
                        }
                    }
                }
            }
            return decryptedText;
        }
    }
}

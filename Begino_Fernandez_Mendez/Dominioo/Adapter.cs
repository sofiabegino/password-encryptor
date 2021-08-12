using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Adapter : IEncryptor
    {
            private byte[] Key = Encoding.UTF8.GetBytes("mysmallkey123456");
            private byte[] IV = Encoding.UTF8.GetBytes("mysmallkey123456");

            public string Encrypt(string plainText)
            {
                byte[] encrypted;
                using (AesManaged aes = new AesManaged())
                {
                    ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                                sw.Write(plainText);
                            encrypted = ms.ToArray();
                        }
                    }
                }
                return Convert.ToBase64String(encrypted);
            }

            public string Decrypt(string cipherText)
            {
                string plaintext = null;
                byte[] cipher = Convert.FromBase64String(cipherText);
                using (AesManaged aes = new AesManaged())
                {
                    ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                    using (MemoryStream ms = new MemoryStream(cipher))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                                plaintext = reader.ReadToEnd();
                        }
                    }
                }
                return plaintext;
            }
        }

    }

using System.IO;
using System.Security.Cryptography;

namespace Dominio
{
    public interface IEncryptor
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}
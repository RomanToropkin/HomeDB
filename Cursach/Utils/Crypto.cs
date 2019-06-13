using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Cursach.Utils
{
    /// <summary>
    /// Криптография. шифровка/дешифровка файла методом AES.
    /// </summary>
    public class Crypto
    {
        /// <summary>
        /// Процесс шифрования/дешифрования
        /// </summary>
        /// <param name="inputPath">Путь к файлу</param>
        /// <param name="password">Криптографический пароль</param>
        /// <param name="encryptMode">Режим шифрования</param>
        /// <param name="outputPath">Выходной путь файла</param>
        public static void ProcessFile(string inputPath, string password, bool encryptMode, string outputPath)
        {
            using (var cypher = new AesManaged())
            using (var fsIn = new FileStream(inputPath, FileMode.OpenOrCreate))
            using (var fsOut = new FileStream(outputPath, FileMode.Create))
            {
                try
                {
                    const int saltLength = 256;
                    var salt = new byte[saltLength];
                    var iv = new byte[cypher.BlockSize / 8];

                    if (encryptMode)
                    {
                        using (var rng = new RNGCryptoServiceProvider())
                        {
                            rng.GetBytes(salt);
                            rng.GetBytes(iv);
                        }

                        fsOut.Write(salt, 0, salt.Length);
                        fsOut.Write(iv, 0, iv.Length);
                    }
                    else
                    {
                        fsIn.Read(salt, 0, saltLength);
                        fsIn.Read(iv, 0, iv.Length);
                    }

                    var pdb = new Rfc2898DeriveBytes(password, salt);
                    var key = pdb.GetBytes(cypher.KeySize / 8);

                    using (var cryptoTransform = encryptMode
                        ? cypher.CreateEncryptor(key, iv)
                        : cypher.CreateDecryptor(key, iv))
                    using (var cs = new CryptoStream(fsOut, cryptoTransform, CryptoStreamMode.Write))
                    {
                        fsIn.CopyTo(cs);
                    }
                }
                catch (Exception)
                {
                   //ignored
                }
            }
        }
    }
}
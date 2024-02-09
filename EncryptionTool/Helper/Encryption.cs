using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncryptionTool.Helper
{
    public class Encryption
    {

        public string Encrypt(string plainText, int shift)
        {
            return CaesarCipher.Encrypt(plainText, shift);
        }

        public string Decrypt(string encryptedText, int shift)
        {
            return CaesarCipher.Decrypt(encryptedText, shift);
        }

    }
}
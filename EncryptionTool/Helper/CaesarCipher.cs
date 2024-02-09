using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncryptionTool.Helper
{
    public class CaesarCipher
    {
        // Encrypts text using a Caesar Cipher with a given shift value
        public static string Encrypt(string plainText, int shift)
        {
            string encryptedText = "";

            foreach (char c in plainText)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = (char)(c + shift);

                    if (char.IsLower(c))
                    {
                        if (encryptedChar > 'z')
                            encryptedChar = (char)(encryptedChar - 26);
                    }
                    else if (char.IsUpper(c))
                    {
                        if (encryptedChar > 'Z')
                            encryptedChar = (char)(encryptedChar - 26);
                    }

                    encryptedText += encryptedChar;
                }
                else
                {
                    encryptedText += c;
                }
            }

            return encryptedText;
        }

        // Decrypts text encrypted with a Caesar Cipher and a given shift value
        public static string Decrypt(string encryptedText, int shift)
        {
            string decryptedText = "";

            foreach (char c in encryptedText)
            {
                if (char.IsLetter(c))
                {
                    char decryptedChar = (char)(c - shift);

                    if (char.IsLower(c))
                    {
                        if (decryptedChar < 'a')
                            decryptedChar = (char)(decryptedChar + 26);
                    }
                    else if (char.IsUpper(c))
                    {
                        if (decryptedChar < 'A')
                            decryptedChar = (char)(decryptedChar + 26);
                    }

                    decryptedText += decryptedChar;
                }
                else
                {
                    decryptedText += c;
                }
            }

            return decryptedText;
            //return Encrypt(encryptedText, -shift);
        }
    }
}
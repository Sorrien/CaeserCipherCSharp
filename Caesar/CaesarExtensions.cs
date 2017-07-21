using System;
using System.Collections.Generic;
using System.Text;

namespace Caesar
{
    public static class CaesarExtensions
    {
        public static char CaesarEncrypt(this char ch, int code)
        {
            if (ch.IsLetter())
            {
                char offset = ch.IsUpper() ? 'A' : 'a';
                ch = (char)((ch + code - offset) % 26 + offset);
            }
            return ch;
        }
        public static string CaesarEncrypt(this string message, int code)
        {
            string encrypted = "";
            foreach (char ch in message)
            {
                encrypted += CaesarEncrypt(ch, code);
            }
            return encrypted;
        }

        public static string CaesarDecrypt(this string message, int code)
        {
            string decrypted = "";
            foreach (char ch in message)
            {
                decrypted += CaesarEncrypt(ch, (26 - code));
            }
            return decrypted;
        }
        public static string[] CaesarDecrypt(this string message)
        {
            string[] results = new string[26];
            for (int i = 0; i < 26; i++)
            {
                results[i] = CaesarDecrypt(message, i + 1);
            }
            return results;
        }
    }
}

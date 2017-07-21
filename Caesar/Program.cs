using System;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Message:");
            string message = Console.ReadLine();
            Console.WriteLine("Code:");
            int code = int.Parse(Console.ReadLine());

            string encrypted = message.CaesarEncrypt(code);

            string decrypted = encrypted.CaesarDecrypt(code);

            Console.WriteLine(message + "\n" + encrypted + "\n" + decrypted);

            string[] decryptionAttempts = encrypted.CaesarDecrypt();

            foreach(string attempt in decryptionAttempts)
            {
                Console.WriteLine(attempt);
            }

            Console.ReadLine();
        }
    }
}
using System;

namespace AESCryptographyProject
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            // Input plaintext message
            Console.WriteLine("Enter a message to encrypt:");
            string? plaintext = Console.ReadLine();

            // Generate a random key and IV
            byte[] key = KeyGenerator.GenerateKey();
            byte[] iv = KeyGenerator.GenerateIV();

            // Encrypt the message
            AESEncryptor encryptor = new AESEncryptor();
            byte[] encrypted = encryptor.Encrypt(plaintext!, key, iv);
            Console.WriteLine("\nEncrypted Message:");
            Console.WriteLine(Convert.ToBase64String(encrypted));

            // Decrypt the message
            AESDecryptor decryptor = new AESDecryptor();
            string decrypted = decryptor.Decrypt(encrypted, key, iv);
            Console.WriteLine("\nDecrypted Message:");
            Console.WriteLine(decrypted);
        }
    }
}
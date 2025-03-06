using Microsoft.VisualStudio.TestTools.UnitTesting;
using AESCryptographyProject;
using System;
using System.Security.Cryptography;

namespace AESCryptographyProject.Tests
{
    [TestClass]
    public class AESDecryptorTests
    {
        [TestMethod]
        public void Decrypt_ValidInput_ReturnsOriginalPlaintext()
        {
            // Arrange
            var key = KeyGenerator.GenerateKey();
            var iv = KeyGenerator.GenerateIV();
            var encryptor = new AESEncryptor();
            var decryptor = new AESDecryptor();
            var originalPlaintext = "This is a secret message!";

            // Act
            var cipherText = encryptor.Encrypt(originalPlaintext, key, iv);
            var decryptedText = decryptor.Decrypt(cipherText, key, iv);

            // Assert
            Assert.AreEqual(originalPlaintext, decryptedText);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Decrypt_NullCipherText_ThrowsArgumentNullException()
        {
            // Arrange
            var decryptor = new AESDecryptor();
            byte[] cipherText = null!;
            var key = KeyGenerator.GenerateKey();
            var iv = KeyGenerator.GenerateIV();

            // Act
            decryptor.Decrypt(cipherText!, key, iv);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Decrypt_NullKey_ThrowsArgumentNullException()
        {
            // Arrange
            var decryptor = new AESDecryptor();
            var cipherText = new byte[16]; // Dummy cipher text
            byte[] key = null!;
            var iv = KeyGenerator.GenerateIV();

            // Act
            decryptor.Decrypt(cipherText, key, iv);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Decrypt_NullIV_ThrowsArgumentNullException()
        {
            // Arrange
            var decryptor = new AESDecryptor();
            var cipherText = new byte[16]; // Dummy cipher text
            var key = KeyGenerator.GenerateKey();
            byte[] iv = null!;

            // Act
            decryptor.Decrypt(cipherText, key, iv);

            // Assert is handled by ExpectedException
        }
    }
}
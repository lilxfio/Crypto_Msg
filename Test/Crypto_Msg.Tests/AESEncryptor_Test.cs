using Microsoft.VisualStudio.TestTools.UnitTesting;
using AESCryptographyProject;
using System;

namespace AESCryptographyProject.Tests
{
    [TestClass]
    public class AESEncryptorTests
    {
        [TestMethod]
        public void Encrypt_ValidInput_ReturnsEncryptedData()
        {
            // Arrange
            var key = KeyGenerator.GenerateKey();
            var iv = KeyGenerator.GenerateIV();
            var encryptor = new AESEncryptor();
            var plainText = "This is a secret message!";

            // Act
            var encryptedData = encryptor.Encrypt(plainText, key, iv);

            // Assert
            Assert.IsNotNull(encryptedData);
            Assert.IsTrue(encryptedData.Length > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Encrypt_NullPlainText_ThrowsArgumentNullException()
        {
            // Arrange
            var encryptor = new AESEncryptor();
            string plainText = null!;
            var key = KeyGenerator.GenerateKey();
            var iv = KeyGenerator.GenerateIV();

            // Act
            encryptor.Encrypt(plainText, key, iv);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Encrypt_NullKey_ThrowsArgumentNullException()
        {
            // Arrange
            var encryptor = new AESEncryptor();
            var plainText = "This is a secret message!";
            byte[] key = null!;
            var iv = KeyGenerator.GenerateIV();

            // Act
            encryptor.Encrypt(plainText, key, iv);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Encrypt_NullIV_ThrowsArgumentNullException()
        {
            // Arrange
            var encryptor = new AESEncryptor();
            var plainText = "This is a secret message!";
            var key = KeyGenerator.GenerateKey();
            byte[] iv = null!;

            // Act
            encryptor.Encrypt(plainText, key, iv);

            // Assert is handled by ExpectedException
        }
    }
}
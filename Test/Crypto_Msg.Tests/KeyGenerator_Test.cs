using Microsoft.VisualStudio.TestTools.UnitTesting;
using AESCryptographyProject;
using System;

namespace AESCryptographyProject.Tests
{
    [TestClass]
    public class KeyGeneratorTests
    {
        [TestMethod]
        public void GenerateKey_ReturnsValidKey()
        {
            // Arrange & Act
            var key = KeyGenerator.GenerateKey();

            // Assert
            Assert.IsNotNull(key);
            Assert.AreEqual(32, key.Length); // AES-256 key size is 32 bytes
        }

        [TestMethod]
        public void GenerateIV_ReturnsValidIV()
        {
            // Arrange & Act
            var iv = KeyGenerator.GenerateIV();

            // Assert
            Assert.IsNotNull(iv);
            Assert.AreEqual(16, iv.Length); // AES block size is 16 bytes
        }
    }
}
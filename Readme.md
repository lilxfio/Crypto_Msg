# AES Cryptography Project

This project demonstrates the use of AES (Advanced Encryption Standard) for encrypting and decrypting messages in C#. It includes a key generator, an encryptor, a decryptor, and unit tests to ensure the functionality works as expected.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Setup](#setup)
- [Usage](#usage)
- [Running Tests](#running-tests)
- [Project Structure](#project-structure)
- [Contributors](#contributors)
- [License](#license)

## Features

- **Key Generation**: Generates a random key and initialization vector (IV) for AES encryption.
- **Encryption**: Encrypts a plaintext message using AES.
- **Decryption**: Decrypts an encrypted message back to its original plaintext.
- **Unit Tests**: Includes unit tests for the `AESEncryptor`, `AESDecryptor`, and `KeyGenerator` classes.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 9.0 or later)
- An IDE or text editor (e.g., Visual Studio, Visual Studio Code, or JetBrains Rider)

## Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/aes-cryptography-project.git
   cd aes-cryptography-project

2. **Restore dependencies**:
   ```bash
      dotnet restore 
   ```
3. **Build the project**:
   ```bash
    dotnet build
    ```
## Usage
1. **Run the program**:

    Navigate to the Program.cs file and run the project:

```bash
Copy
dotnet run --project src/Crypto.csproj
```
2. **Enter a message**:

     The program will prompt you to enter a message to encrypt. After entering the message, it will display the encrypted message (in Base64 format) and then decrypt it back to the original plaintext.

Example output:

```
Enter a message to encrypt:
Hello, World!

Encrypted Message:
AQIDBAUGBwgJCgsMDQ4PEBESExQVFhcYGRobHB0eHyAhIiMkJSYnKCkqKywtLi8wMTIzNDU2Nzg5Ojs8PT4/QEFCQ0RFRkdISUpLTE1OT1BRUlNUVVZXWFlaW1xdXl9gYWJjZGVmZ2hpamtsbW5vcHFyc3R1dnd4eXp7fH1+f4CBgoOEhYaHiImKi4yNjo+QkZKTlJWWl5iZmpucnZ6foKGio6SlpqeoqaqrrK2ur7CxsrO0tba3uLm6u7y9vr/AwcLDxMXGx8jJysvMzc7P0NHS09TV1tfY2drb3N3e3+Dh4uPk5ebn6Onq6+zt7u/w8fLz9PX29/j5+vv8/f7/

Decrypted Message:
Hello, World!   

```
## Running Tests
 
  To run the unit tests, use the following command:

```bash

dotnet test
```

This will execute all the unit tests in the AESDecryptor_Test.cs and AESEncryptor_Test.cs files.

## Project Structure

- src/

    - ***AESDecryptor.cs***: Contains the AESDecryptor class for decrypting AES-encrypted messages.

    - ***AESEncryptor.cs***: Contains the AESEncryptor class for encrypting plaintext messages using AES.

    - ***KeyGenerator.cs***: Contains the KeyGenerator class for generating AES keys and IVs.

    - ***Program.cs***: The main program that demonstrates encryption and decryption.

- tests/

   - ***AESDecryptor_Test.cs***: Unit tests for the AESDecryptor class.

  - ***AESEncryptor_Test.cs***: Unit tests for the AESEncryptor class.

  - ***Crypto_Msg.Tests.csproj***: The project file for the unit tests.

## Contributors

- **Fiordi Toska** - Project Developer
- Contributions welcome! Feel free to submit a pull request or raise an issue.

---

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
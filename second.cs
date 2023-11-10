    static string CombineEncryptions(string classicalEncryptedMessage, string quantumKey)
    {
        // Combine classical and quantum encryption
        // For simplicity, we'll XOR each character of the classical encryption with the quantum key
        char[] classicalEncryptedArray = classicalEncryptedMessage.ToCharArray();
        char[] quantumKeyArray = quantumKey.ToCharArray();

        for (int i = 0; i < classicalEncryptedArray.Length; i++)
        {
            classicalEncryptedArray[i] ^= quantumKeyArray[i % quantumKeyArray.Length];
        }

        return new string(classicalEncryptedArray);
    }

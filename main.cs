using System;

class QuantumCipher
{
    static void Main()
    {
// to be merged
        string originalMessage = "abcdef";

        string classicalEncryptedMessage = ClassicalEncrypt(originalMessage);
        Console.WriteLine($"Classical Encrypted Message: {classicalEncryptedMessage}");

        string quantumKey = QuantumKeyDistribution();
        Console.WriteLine($"Quantum Key: {quantumKey}");

        string finalEncryptedMessage = CombineEncryptions(classicalEncryptedMessage, quantumKey);
        Console.WriteLine($"Final Encrypted Message: {finalEncryptedMessage}");
    }

    static string ClassicalEncrypt(string message)
    {

        char[] charArray = message.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string QuantumKeyDistribution()
    {

        Random random = new Random();
        int keyLength = 16;
        char[] key = new char[keyLength];

        for (int i = 0; i < keyLength; i++)
        {
            key[i] = (char)random.Next('A', 'Z' + 1);
        }

        return new string(key);
    }

    static string CombineEncryptions(string classicalEncryptedMessage, string quantumKey)
    {
        char[] classicalEncryptedArray = classicalEncryptedMessage.ToCharArray();
        char[] quantumKeyArray = quantumKey.ToCharArray();

        for (int i = 0; i < classicalEncryptedArray.Length; i++)
        {
            classicalEncryptedArray[i] ^= quantumKeyArray[i % quantumKeyArray.Length];
        }

        return new string(classicalEncryptedArray);
    }
}

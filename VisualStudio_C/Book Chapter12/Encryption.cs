using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter12 {
    class Encryption {
        public static byte[] key;
        public static byte[] IV;

        public static void Main() {
            //var encryptkey = "031485A7F4E44699";
            //var IV = "aqe1234fwdet234";
            var data = "Esta mensagem foi encriptada!";
            var encryptedData = EncryptData(GetBytes(data));
            Console.WriteLine(GetString(GetBytes(data)));
            Console.WriteLine(GetString(encryptedData));
            Console.WriteLine(GetString(DecryptData(encryptedData)));
            Console.ReadKey();
        }
        public static byte[] EncryptData(byte[] plainData) {
            SymmetricAlgorithm cryptoalgorithm = SymmetricAlgorithm.Create("DES");
            ICryptoTransform encryptor = cryptoalgorithm.CreateEncryptor();
            byte[] cypherData = encryptor.TransformFinalBlock(plainData, 0, plainData.Length);
            key = cryptoalgorithm.Key;
            IV = cryptoalgorithm.IV;
            return cypherData;
        }

        public static byte[] DecryptData(byte[] cipherData) {
            SymmetricAlgorithm cryptoAlgorythm = SymmetricAlgorithm.Create("DES");
            ICryptoTransform decryptor = cryptoAlgorythm.CreateDecryptor(key, IV);
            byte[] plainData = decryptor.TransformFinalBlock(cipherData, 0, cipherData.Length);
            return plainData;
        }

        public static byte[] GetBytes(string str) {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetString(byte[] bytes) {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter12 {
    class Hashing {
        public static void MainHashing() {
            var hash = ComputeHash("test");
            Console.WriteLine(hash);
            Console.WriteLine(VerifyHash("test", hash));    
        }

        public static string ComputeHash(string input) {
            HashAlgorithm sha = SHA256.Create();
            byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(input));
            return Convert.ToBase64String(hashData);
        }

        public static bool VerifyHash(string input, string hashValue) {
            HashAlgorithm sha = SHA256.Create();
            byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(input));
            return Convert.ToBase64String(hashData) == hashValue;
        }

    }
}

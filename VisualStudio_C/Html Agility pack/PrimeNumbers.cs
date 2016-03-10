using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace VisualStudio_C.Html_Agility_pack {
    class GetAllPrimes {
        public static void Main() {

            int [] A = new int []{ 1, 2, 3, 1999, Int32.MaxValue, 1, 3, 5, 6, 7, 9, 11, 12, 21, 1, 41 };
            int biggestNumber = A[0];
            for(int i=1; i<A.Length; i++) {
                if(A[i] > biggestNumber) {
                    biggestNumber = A[i];
                }
            }
            double decimalBiggestNumber = biggestNumber;
            int sizeAuxArray = Convert.ToInt32(Math.Sqrt(decimalBiggestNumber));
            Console.WriteLine("Size Prime Numbers: "+ sizeAuxArray);

            var auxArray = new int[sizeAuxArray];
            var listPrime = new List<int>();

            for(int i=0; i< sizeAuxArray-1; i++) {
                auxArray[i] = i;
            }
            auxArray[0] = 0;
            auxArray[1] = 0;
            int prime = 2;

            bool emptyArray = false;
            while(!emptyArray) {
                listPrime.Add(prime);

                for(int i = prime; i<sizeAuxArray; i += prime) {
                    auxArray[i] = 0;
                }
                for(int j = 0; j < sizeAuxArray; j++) {
                    if(auxArray[j] > 0) {
                        prime = auxArray[j];
                        break;
                    }
                    if(j== sizeAuxArray - 1) {
                        emptyArray = true;
                        break;
                    }
                }
            }

            foreach(var item in listPrime) {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

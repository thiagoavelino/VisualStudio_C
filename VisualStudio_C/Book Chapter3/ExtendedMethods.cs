using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Chapter3 {
    public static class MyExtendedMethods {
        public static int square(this int num) {
            int result = 0;
            result = num * num;
            return result;
        }
    }
    class ExtendedMethods {
        static void MainExtendedMethods(string[] args) {
            var myNum = 3;
            myNum.square();
            Console.WriteLine(myNum + 3);
            Console.ReadKey();
        }
    }
}

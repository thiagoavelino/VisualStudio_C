using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter4 {
    class ValueTypes {
        static void MainValueTypes(string[] args) {
            //long big = 1000000000000;
            //checked {
            //    uint small = (uint)big;
            //    Console.WriteLine(small);
            //}
            float test = 10.9F;
            int testint = (int)test;
            Console.WriteLine(testint);

            //Conversions using Parse
            //var stringTest = Console.ReadLine();
            //bool boooll;
            //if(!bool.TryParse(stringTest, out boooll)) boooll = false;
            //if(boooll) Console.WriteLine("True Conversion");
            //else Console.WriteLine("False Conversion");
            //Console.ReadKey();

            //using options

            decimal amount = decimal.Parse("$123,456.78",NumberStyles.AllowCurrencySymbol);
            Console.WriteLine(amount);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter4 {
    class StringExperiments {
        static void MainStringExperiments(string[] args) {
            for(int i = 1; i <= 10; i++) {
                string indent = new string('*', 4 * i);
                Console.WriteLine(indent + i.ToString());
            }
            

            string[] employeeNames =
            {
            "Able",
            "Baker",
            "Charley",
            "Davis",
            };
            StringBuilder allNames = new StringBuilder();
            foreach(string name in employeeNames) {
                allNames.Append("[" + name + "]" + Environment.NewLine);
            }
            Console.WriteLine(allNames.ToString());
            Console.WriteLine(String.Format("{{ My name is bound. }}"));


            int num1 = 10, num2 = 9;
            int result = num1 ^ num2;
            Console.WriteLine(result);

            string string1 = "Hello World";
            //string string2 = "Hello " + "World";
            string string2 = string.Copy(string1);

            Console.WriteLine(String.Format("strings are {0} an {1}", string1, string2));
            Console.WriteLine(string1 == string2);
            Console.WriteLine(ReferenceEquals(string1,string2));
            

            var stringVbColor = "&HC0C0C0";
            var stringCSharp = "#" + stringVbColor.Substring(2);
            Console.WriteLine(stringCSharp);
            Console.ReadKey();
        }
    }
}

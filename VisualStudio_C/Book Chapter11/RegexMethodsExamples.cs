using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter11 {
    class RegexMethodsExamples {
        static void MainRegexMethods() {
            var stringtest = "test test thiago testttttt";
            var stringempty = "";
            string stringnull = null;
            string stringwhitespaces = "          ";

            if(stringtest.Contains("test")) {
                Console.WriteLine("It contains");
            }
            if(stringtest.EndsWith("ttt")) {
                Console.WriteLine("yes it ends with");
            }
            Console.WriteLine("thiago substring is in index of {0}", stringtest.IndexOf("thiago"));
            Console.WriteLine("nonexistent substring is in index of {0}", stringtest.IndexOf("nonexistent"));

            if(String.IsNullOrEmpty(stringempty)) {
                Console.WriteLine("Empty");
            }
            if(String.IsNullOrEmpty(stringnull)) {
                Console.WriteLine("Null");
            }
            if(String.IsNullOrWhiteSpace(stringwhitespaces)) {
                Console.WriteLine("Whitespaces");
            }

            Console.WriteLine("test substring is in lastindex of {0}", stringtest.LastIndexOf("test"));

            Console.WriteLine("thiago substring is removed: {0}", stringtest.Remove(10,6));

            Console.WriteLine("thiago substring is replaced with lucas: {0}", stringtest.Replace("thiago", "lucas"));

            foreach(var item in stringtest.Split(new string[] { "test" },StringSplitOptions.RemoveEmptyEntries)) {
                Console.WriteLine("Splitted item: {0}", item);
            }

            var input = "a@test";
            var pattern = "[a-z]@";
            if(Regex.IsMatch(input, pattern)) {
                Console.WriteLine("Regex works");
            } else {
                Console.WriteLine("Regex failed");
            }
            Console.Read();
        }
    }
}

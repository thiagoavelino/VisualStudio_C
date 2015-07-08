using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter4 {
    class DynamicTypes {
        static void MainDynamicType(string[] args) {
            var engine = Python.CreateEngine();
            var python =
@"
def Add(a,b):
    return a+b;
";
            var source = engine.CreateScriptSourceFromString(python);
            var scope = engine.CreateScope();
            source.Execute(scope);
            dynamic scope2 = scope;
            var x = scope2.Add(2, 1);
            Console.WriteLine(x);
            var y = scope2.Add("Hello ", "World");
            Console.WriteLine(y);
            var z = scope2.Add(DateTime.Now, TimeSpan.FromHours(1));
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
    public class Vector {
        public static Vector operator +(Vector v1, Vector v2) {
            return v1;
        }
    }
}

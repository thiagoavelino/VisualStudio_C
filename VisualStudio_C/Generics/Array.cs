using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Generics {
    public class Array {
        static void MainArray(string[] args) {
            var arrayEmployee = new Employee[3] {
                new Employee{Name ="Joe"},
                new Employee{Name = "John"},
                new Employee{Name = "Peter"}
                };
            foreach(var item in arrayEmployee) {
                Console.WriteLine(item.Name);
            }
            Console.Read();

        }
    }
}

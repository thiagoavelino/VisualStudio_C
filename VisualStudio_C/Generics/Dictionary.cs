using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Generics {
    class Dictionary {
        static void MainDictionary(string[] args) {
            var employeesByName = new Dictionary<string, Employee>();
            employeesByName.Add("Thiago", new Employee { Name = "Thiago" });
            employeesByName.Add("John", new Employee { Name = "John" });
            employeesByName.Add("Scott", new Employee { Name = "Scott" });

            var scott = employeesByName["Scott"];

            foreach(var item in employeesByName) {
                Console.WriteLine("{0};{1}",item.Key,item.Value.Name);
            }

            //employees by departament
            var employeeByDepartament = new SortedDictionary<string, List<Employee>>();
            employeeByDepartament.Add("Sales", new List<Employee>{
                                        new Employee{Name="Susan"},
                                        new Employee{Name="Monica"}
            });
            employeeByDepartament.Add("Engineering", new List<Employee>{
                                        new Employee{Name="Thiago"},
                                        new Employee{Name="Peter"}
            });
            employeeByDepartament.Add("HR", new List<Employee>{
                                        new Employee{Name="Roger"},
                                        new Employee{Name="Scott"}
            });
            

            foreach(var item in employeeByDepartament) {
                Console.WriteLine(item.Key);
                foreach(var employee in item.Value) {
                    Console.WriteLine(employee.Name);
                }
                Console.WriteLine("-------------------");
            }
            Console.ReadKey();


        }
    }
}

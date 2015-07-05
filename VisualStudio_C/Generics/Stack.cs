using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Generics {
    class Stack {
        static void MainStack(string[] args) {
            var stackEmployee = new Stack<Employee>();
            stackEmployee.Push(new Employee { Name = "Joe" });
            stackEmployee.Push(new Employee { Name = "John" });
            stackEmployee.Push(new Employee { Name = "Peter" });

            for(int i = 0; i < 3; i++) {
                Console.WriteLine(stackEmployee.Peek().Name);
                stackEmployee.Pop();
            }

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Generics {
    class Queue {
        static void MainQueue(string[] args) {
            var queueEmployee = new Queue<Employee>();
            queueEmployee.Enqueue(new Employee{Name ="Joe"});
            queueEmployee.Enqueue(new Employee{Name = "John"});
            queueEmployee.Enqueue(new Employee { Name = "Peter" });

            for (int i = 0; i < 3; i++)
			{
			    Console.WriteLine(queueEmployee.Peek().Name);
                queueEmployee.Dequeue();
			}

            Console.Read();
        }
    }
}

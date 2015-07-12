using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter5.DisposableCourse {
    class Program {
        static void Main(string[] args) {
            { 
                using(var state = new DatabaseState()) {
                    Console.WriteLine(state.GetDate());
                }
                Console.ReadKey();
            }
            {
                for(int i = 0; i < 1000; i++) {
                    var state = new DatabaseState();
                    Console.WriteLine(state.GetDate());
                }
                Console.ReadKey();
            }
        }
    }
}

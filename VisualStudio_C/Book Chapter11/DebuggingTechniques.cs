#define DEBUG1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter11 {
    class DebuggingTechniques {
        public static void Main() {
            Console.WriteLine("Debugging");

#if DEBUG1
#warning Using obsolete method to calculate fees."
#endif

            Console.ReadKey();
        }
    }
}

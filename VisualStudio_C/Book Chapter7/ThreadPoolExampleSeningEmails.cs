using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class ThreadPoolExampleSeningEmails {
        public static void MainThreadPool() {
            for(int i = 0; i < 100; i++) {
                ThreadPool.QueueUserWorkItem((x) => {
                    var a = i;
                    Thread.Sleep(1*a);
                    Console.WriteLine("test {0}",a);
                });    
            }
            Console.ReadKey();
        }
    }
}

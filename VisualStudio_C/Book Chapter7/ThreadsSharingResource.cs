using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class ThreadsSharingResource {
        static int sum = 0;
        public static void MainThreadsSharingResource() {
            Thread[] threads = new Thread[10];
            for(int i = 0; i < threads.Length; i++) {
                threads[i] = new Thread(AddOne);
                threads[i].Start();
            }
            for(int i = 0; i < threads.Length; i++) {
                threads[i].Join();
            }
            Console.WriteLine("[{0}] - Sum is {1}",
                                Thread.CurrentThread.ManagedThreadId,
                                sum);
            Console.ReadKey();
        }

        private static void AddOne() {
            Console.WriteLine("[{0}] - AddOne Called",
                                Thread.CurrentThread.ManagedThreadId,
                                sum);
            Interlocked.Increment(ref sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStudio_C.Book_Chapter7 {
    class Program {
        static volatile bool cancel = false;

        static void Main(string[] args) {
            
                Console.WriteLine("{0} Main called", Thread.CurrentThread.ManagedThreadId);
                for(int i = 0; i < 100; i++) {
                    ThreadPool.QueueUserWorkItem(SayHelloiteration2, i);
                }    
            
                //t.Join();
                Thread.Sleep(rnd.Next(250, 500));
                Console.WriteLine("{0} Main done", Thread.CurrentThread.ManagedThreadId);

            //}
            #region RanCode
            //{
            //    Console.ReadLine();
            //    Thread t = new Thread(SayHelloLoop);
                
            //    Console.WriteLine("Press ENTER to cancel.");
            //    t.Start();
            //    Console.ReadLine();
            //    cancel = true;
            //    t.Join();
            //    Console.WriteLine("Done");
            //}
            //{
            //    Console.ReadLine();
            //    Application.Run(new Form1()); }
            //{
            //    Console.WriteLine("{0} Main called", Thread.CurrentThread.ManagedThreadId);
            //    Console.WriteLine("{0} Processor/core count = {1}",
            //        Thread.CurrentThread.ManagedThreadId,
            //        Environment.ProcessorCount);
            //    Thread t = new Thread(SayHello);
            //    t.Name = "Hello Thread";
            //    t.Priority = ThreadPriority.BelowNormal;
            //    t.Start();
            //    Console.WriteLine("{0} Main done", Thread.CurrentThread.ManagedThreadId);

            //}
            #endregion 
        }
        static Random rnd = new Random();

        private static void SayHelloiteration2(object obj) {
            Thread.Sleep(rnd.Next(250, 500));
            int iteration = (int)obj;
            Console.WriteLine("[{0}] Hello, World {1}! [{2}]",
                                    Thread.CurrentThread.ManagedThreadId,
                                    iteration,
                                    Thread.CurrentThread.IsBackground);
                
            
        }

        private static void SayHelloiteration(object obj) {
            int iteration = (int)obj;
            if(iteration > 0) {
                for(int i = 0; i < iteration; i++) {
                    Console.WriteLine("[{0}] Hello, World {1}! [{2}]",
                                        Thread.CurrentThread.ManagedThreadId,
                                        i,
                                        Thread.CurrentThread.IsBackground);
                }
            }
        }

        static void SayHelloLoop(object obj) {
            while(!cancel) {
                Console.WriteLine("Hello, World!");
                //Thread.Sleep(10);
            }
        }
        static void SayHello() {
            Console.WriteLine("{0} Hello, World!", Thread.CurrentThread.ManagedThreadId);
        }
    }
}

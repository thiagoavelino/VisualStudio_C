using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class SimpleThreadComparing {
        static void Main() {
            Stopwatch sw = Stopwatch.StartNew();
            RunSequential();
            Console.WriteLine("Sequential - We're done in {0}ms", sw.ElapsedMilliseconds);
            Stopwatch sw2 = Stopwatch.StartNew();
            RunAsync();
            Console.WriteLine("Async - We're done in {0}ms", sw2.ElapsedMilliseconds);
            Console.ReadKey();
        }

        static void RunAsync() {
            double result = 0d;
            var thread = new Thread(() => result = ReadDataFromIO());
            thread.Start();
            double result2 = DoIntensiveCalculations();
            thread.Join();
            result += result2;
            Console.WriteLine("The result is {0}", result);
        }

        static void RunSequential() {
            double result = 0d;
            result += ReadDataFromIO();
            result += DoIntensiveCalculations();
            Console.WriteLine("The result is {0}", result);
        }

        static double ReadDataFromIO(){
            Thread.Sleep(5000);
            return 10d;
        }

        static double DoIntensiveCalculations() {
            double result = 1000000000d;
            var maxValue = Int32.MaxValue;
            for(int i = 1; i < maxValue; i++) {
                result /= i;
            }
            return result + 10d;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class ProgramProcessArray {
        public static void Main() {
            int coreCount = Environment.ProcessorCount;
            Console.WriteLine("Process/core count = {0}", coreCount);

            double[] data = GetData();

            Stopwatch sw = Stopwatch.StartNew();
            ArrayProcessor wholeArray = new ArrayProcessor(data, 0, data.Length - 1);
            wholeArray.ComputeSum();
            sw.Stop();
            Console.WriteLine("1 thread computed {0:n0} in {1:n0}ms", 
                                wholeArray.Sum, 
                                sw.ElapsedMilliseconds);
            Console.ReadKey();
        }

        private static double[] GetData() {
            double[] data = new double[5000];
            for(int i = 0; i < data.Length; i++) {
                data[i] = i;
            }
            return data;
        }
    }
}

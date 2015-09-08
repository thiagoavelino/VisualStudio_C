using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class ProgramProcessArray2 {
        public static void MainProgramProcessArray() {
            int coreCount = Environment.ProcessorCount;
            Console.WriteLine("Process/core count = {0}", coreCount);

            double[] data = GetData();

            Stopwatch sw = Stopwatch.StartNew();

            ArrayProcessor[] slices = new ArrayProcessor[coreCount];
            Thread[] threads = new Thread[coreCount];

            int indexesPerThread = data.Length / coreCount;
            int leftOverIndexes = data.Length % coreCount;

            for(int i = 0; i < coreCount; i++) {
                int firstIndex = (i * indexesPerThread);
                int lastIndex = firstIndex + indexesPerThread - 1;
                if(i == (coreCount - 1)) {
                    lastIndex += leftOverIndexes;
                }
                ArrayProcessor slice = new ArrayProcessor(data, firstIndex, lastIndex);
                slices[i] = slice;
                threads[i] = new Thread(slice.ComputeSum);
                threads[i].Start();
            }
            double sum = 0;
            for(int i = 0; i < coreCount; i++) {
                threads[i].Join();
                sum += slices[i].Sum;
            }
            sw.Stop();
            Console.WriteLine("2 threads computed {0:n0} in {1:n0}ms",
                                sum,
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

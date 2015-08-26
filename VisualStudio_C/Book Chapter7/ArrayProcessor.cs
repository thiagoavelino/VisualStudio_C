using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class ArrayProcessor {
        double[] data;
        int firstIndex;
        int lastIndex;
        public double Sum { get; set; }

        public ArrayProcessor(double[] data, int firstIndex, int lastIndex) {
            this.data = data;
            this.firstIndex = firstIndex;
            this.lastIndex = lastIndex;
        }

        public void ComputeSum() {
            Sum = 0;
            for(int i = firstIndex; i < lastIndex; i++) {
                Sum += data[i];
                Thread.Sleep(1);
            }
        }
    }
}

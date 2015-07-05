using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.GenericInterfaces {
    class Buffer<T> : IBuffer<T> {
        Queue<T> queue = new Queue<T>();

        public bool IsEmpty {
            get { return queue.Count == 0; }
        }

        public T Read() {
            return queue.Dequeue();
        }

        public void Write(T value) {
            queue.Enqueue(value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class Bakery {

        Queue<Donut> donutTray = new Queue<Donut>();
        public Donut GetDonut() {
            lock(donutTray) {
                while(donutTray.Count == 0) {
                    Monitor.Wait(donutTray);
                }
                return donutTray.Dequeue();
            }
        }

        public void ReffilTray(Donut[] freshDonuts) {
            lock(donutTray) {
                foreach(var donut in freshDonuts) {
                    donutTray.Enqueue(donut);
                }
                Monitor.PulseAll(donutTray);
            }
        }
    }



    class Donut {
        public Donut() {
               
        }
    }
}

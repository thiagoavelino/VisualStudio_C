using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter5 {
    class Hooptie2:Car {
        public Hooptie2()
            : base("Cadillac", "Hooptie2", 2008, Color.Black) {
        }

        //You can have new 
        //public new void Start() {
        //    Console.WriteLine("Click click click click");
        //}

        public override void Start() {
            Console.WriteLine("Click click click click");
        }

        public override void PressAccelerator(double howFar) {
            if(howFar < 9) {
                // nothing happens
            } else Console.WriteLine("Cough!");
        }

        public override void PressBreak(double pressure) {
            if(pressure < 5) Console.WriteLine("Squeek");
            else Console.WriteLine("GGGGGGrrrrrrriiiiiinnd");
        }
    }
}

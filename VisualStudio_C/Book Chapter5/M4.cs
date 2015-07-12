using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter5 {
    class M4 : Car {
        public M4():base ("BMW","M4",2008,Color.Silver){
        }

        public override void PressAccelerator(double howFar) {
            Console.WriteLine("Vrum Vrum");
        }

        public override void PressBreak(double pressure) {
            Console.WriteLine("Stopped on a dime!");
        }
    }
}

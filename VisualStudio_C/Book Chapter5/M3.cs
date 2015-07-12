using System;
using System.Drawing;

namespace VisualStudio_C.Book_Chapter5 {
    public class M3 : ICar{

        public void Start() {
            Console.WriteLine("Roar!");
        }

        public void PressAccelerator(double howFar) {
            Console.WriteLine("Vrum Vrum");
        }

        public void PressBreak(double pressure) {
            Console.WriteLine("Stopped on a dime!");
        }

        public string Make {
            get { return "BMW"; }
        }

        public string Model {
            get { return "M3"; }
        }

        public int Year {
            get { return 2015; }
        }

        public Color Color {
            get;
            set;
        }
    }
}

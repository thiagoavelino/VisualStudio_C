using System;
using System.Drawing;

namespace VisualStudio_C.Book_Chapter5 {
    public abstract class Car {
        
        public Car(string make, string model, int year, Color color) {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public virtual void Start(){
            Console.WriteLine("Roar!");
        }

        public abstract void PressAccelerator(double howFar);
        public abstract void PressBreak(double pressure);

        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public Color Color { get; set; }
    }
}

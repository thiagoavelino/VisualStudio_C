using System;
using System.Drawing;

namespace VisualStudio_C.Book_Chapter5 {
    public interface ICar {
        void Start();
        void PressAccelerator(double howFar);
        void PressBreak(double pressure);

        string Make { get; }
        string Model { get; }
        int Year { get; }
        Color Color { get; }
    }
}

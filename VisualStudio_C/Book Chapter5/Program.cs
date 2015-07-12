using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter5 {
    class Program {
        static void Main(string[] args) {
            { 
                ICar[] cars = {
                                 new M3{Color = Color.Silver},
                                 new Hooptie{Color = Color.Black},
                             };
                foreach(ICar car in cars) {
                    PrintCarInfo(car);
                    car.Start();
                    car.PressAccelerator(2);
                    car.PressAccelerator(2);
                    car.PressBreak(2);
                    car.PressBreak(10);
                
                }
                Console.ReadKey();
            }
            {
                Car[] cars = {
                                 new M4{Color = Color.Silver},
                                 new Hooptie2{Color = Color.Black},
                             };
                foreach(Car car in cars) {
                    PrintCarInfo(car);
                    car.Start();
                    car.PressAccelerator(2);
                    car.PressAccelerator(2);
                    car.PressBreak(2);
                    car.PressBreak(10);

                }
                Console.ReadKey();
            }

        }
        static void PrintCarInfo(ICar car) {
            Console.WriteLine("Here is a {0} {1} {2} {3}",
                                car.Color.Name, car.Year, car.Make, car.Model);
        }
        static void PrintCarInfo(Car car) {
            Console.WriteLine("Here is a {0} {1} {2} {3}",
                                car.Color.Name, car.Year, car.Make, car.Model);
        }
    }
}

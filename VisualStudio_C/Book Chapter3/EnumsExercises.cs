using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Chapter3 {
    class EnumsExercises {
        // enum called Months, using default initializer
        enum Months { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Nov, Dec };
        // enum call Months, using an overidden initializer
        enum Months2 { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Nov, Dec };
        // using a non-default data type for an enum
        enum Months3 : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Nov, Dec };
        // enumeration to depict airspeeds for aircraft
        enum AirSpeeds { Vx = 55, Vy = 65, Vs0 = 50, Vs1 = 40, Vne = 120 }

        static void MainEnumsExercises(string[] args) {
            string name = Enum.GetName(typeof(Months2), 8);
            Console.WriteLine("The 8th month in the enum is " + name);
            Console.WriteLine("The underlying values of the Months enum:");
            foreach(int values in Enum.GetValues(typeof(Months2))) {
                Console.WriteLine(values);
            }
            Console.ReadKey();
        }
    }   
}

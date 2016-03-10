using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCSharp {
        /*
            PROBLEM Suppose you are in a hallway lined with 100 closed lockers.You begin
        by opening all 100 lockers.Next, you close every second locker.Then you go to
        every third locker and close it if it is open or open it if it’s closed — call this toggling
        the lockers.You continue toggling every nth locker on pass number n. After your
        hundredth pass of the hallway, in which you toggle only locker number 100, how
        many lockers are open?
        */
    class CountingOpenLockers {
        static void Main(string[] args) {
            var lockers = new bool[101];
            //initialize it
            for(int i = 1; i <101; i++) {
                lockers[i] = true;
            }
            for(int i = 2; i < 100; i++) {
                int j = i;
                while( j<100) {
                    lockers[j] = !lockers[j];
                    j += i;
                }
            }
            for(int i = 1; i < 101; i++) {
                Console.WriteLine(i.ToString()+" "+lockers[i].ToString());
            }
            Console.ReadKey();
        }
    }
}

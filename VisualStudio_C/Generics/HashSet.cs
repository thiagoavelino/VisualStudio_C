using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Generics {
    class HashSet {
        static void MainHashSet(string[] args) {
            var set1 = new HashSet<int>{1,2,2,3,4};
            //Doesn't allow duplicated entries
            foreach(var item in set1) {
                Console.WriteLine(item.ToString());
            }
            
            //Intersect
            var set2 = new HashSet<int> { 5, 3, 7, 1, 4 };
            Console.WriteLine("Intersect");
            set1.IntersectWith(set2);
            foreach(var item in set1) {
                Console.WriteLine(item.ToString());
            }

            //Union
            var set3 = new HashSet<int> { 1, 2, 2, 3, 4 };
            Console.WriteLine("Union");
            set3.UnionWith(set2);
            foreach(var item in set3) {
                Console.WriteLine(item.ToString());
            }

            //Symetric ExceptWith
            var set4 = new HashSet<int> { 1, 2, 2, 3, 4 };
            Console.WriteLine("Symetric ExceptWith");
            set4.SymmetricExceptWith(set2);
            foreach(var item in set4) {
                Console.WriteLine(item.ToString());
            }


            Console.Read();
        }
    }
}

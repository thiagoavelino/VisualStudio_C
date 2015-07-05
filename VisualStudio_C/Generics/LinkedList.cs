using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Generics {
    class LinkedList {
        static void MainLinkedList(string[] args) {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            var node = linkedList.First;
            while(node.Value != null) {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}

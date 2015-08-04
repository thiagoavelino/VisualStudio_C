﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStudio_C.Book_Chapter7 {
    class Program {
        static void Main(string[] args) {
            Application.Run(new Form1());
            //Console.WriteLine("{0} Main called", Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine("{0} Processor/core count = {1}", 
            //    Thread.CurrentThread.ManagedThreadId,
            //    Environment.ProcessorCount);
            //Thread t = new Thread(SayHello);
            //t.Name = "Hello Thread";
            //t.Priority = ThreadPriority.BelowNormal;
            //t.Start();
            //Console.WriteLine("{0} Main done", Thread.CurrentThread.ManagedThreadId);
        }
        static void SayHello() {
            Console.WriteLine("{0} Hello, World!", Thread.CurrentThread.ManagedThreadId);
        }
    }
}

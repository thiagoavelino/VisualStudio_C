using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter4 {
    class InteropAndPInvoke {
        static void MainInteropAndPInvoke(string[] args) {
            // Get the long file name.
            string longName = @"C:\eclipse\eclipse\artifacts.xml";
            // Allocate a buffer to hold the result.
            char[] buffer = new char[1024];
            long length = GetShortPathName(
            longName, buffer,
            buffer.Length);
            // Get the short name.
            string shortName = new string(buffer);
            Console.WriteLine(shortName.Substring(0, (int)length));
            Console.ReadKey();

        }
        
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern uint GetShortPathName(string lpszLongPath, char[] lpszShortPath, int cchBuffer);
    }
}

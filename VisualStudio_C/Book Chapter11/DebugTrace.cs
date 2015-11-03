using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter11 {
    class DebugTrace {
        public static void MainDebugTrace() {
            Debug.WriteIf(true, "Will show on the output window.");
            Debug.WriteIf(false, "Will not show on the output window.");
            
            //Trace Listneres
            Stream traceStream = File.Create("TraceFile.txt");
            // Create a TextWriterTraceListener for the trace output file.
            TextWriterTraceListener traceListener = new TextWriterTraceListener(traceStream);
            Trace.Listeners.Add(traceListener);
            // Write a startup note into the trace file.
            Trace.WriteLine("Trace started " + DateTime.Now.ToString());
            Console.ReadKey();
            Trace.WriteLine("Trace ended " + DateTime.Now.ToString());
            Trace.Flush();
            Debug.Assert(false);
        }
    }
}

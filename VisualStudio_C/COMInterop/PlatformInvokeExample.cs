using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace VisualStudio_C.COMInterop {
    class PlatformInvokeExample {
        public void MainPlatformInvoke() {

        }
        [DllImport("dllname.dll", CharSet = CharSet.Unicode)]
        public static extern void Test([MarshalAs(UnmanagedType.LPStr)] string v1);
    }
}

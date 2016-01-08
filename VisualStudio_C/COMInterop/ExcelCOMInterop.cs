using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace VisualStudio_C.COMInterop {
    class ExcelCOMInterop {
        public static void MainInerop() {
            _Application excelApp = new Application();
            excelApp.Visible = true;
        }
    }
}

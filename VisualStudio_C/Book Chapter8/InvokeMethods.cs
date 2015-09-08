using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter8 {
    class InvokeMethods {
        static void MainInvokeMethods() {
            var list = new List<int>();
            Type listType = typeof(List<int>);
            Type[] parameterTypes = { typeof(int) };
            MethodInfo addMethod = listType.GetMethod("Add", parameterTypes);
            Console.WriteLine(addMethod.Invoke(list, new object[] { 7 }));
            Console.ReadKey();

        }
    }
}

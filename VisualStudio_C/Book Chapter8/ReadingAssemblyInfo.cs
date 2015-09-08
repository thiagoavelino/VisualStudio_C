using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter8 {
    class ReadingAssemblyInfo {
        static void MainReadingAssembly() {
            //Assembly myAssembly = Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral," +
            //                                    "PublicKeyToken=b77a5c561934e089");
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Codebase: {0}", myAssembly.CodeBase);
            Console.WriteLine("FullName: {0}", myAssembly.FullName);
            Console.WriteLine("Global Assembly Cache: {0}", myAssembly.GlobalAssemblyCache);
            Console.WriteLine("Image Run Time - CLR Version -: {0}", myAssembly.ImageRuntimeVersion);
            Console.WriteLine("Location: {0}", myAssembly.Location);

            Type[] types = myAssembly.GetTypes();
            foreach(var type in types) {
                Console.WriteLine("Type name: {0}", type.Name);
            }
            Module[] modules = myAssembly.GetModules();
            foreach(var module in modules) {
                Console.WriteLine("Module name: {0}", module.Name);
            }

            Type myType = myAssembly.GetType("VisualStudio_C.Book_Chapter8.TestReflection", true, true);
            Type[] typesOfMethod = { typeof(int) };
            ConstructorInfo myMethod = myType.GetConstructor(typesOfMethod);
            Console.WriteLine("Constructor Example: {0}", myMethod.ReflectedType);
            object[] attributes = myAssembly.GetCustomAttributes(true);
            foreach(object attribute in attributes) {
                Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name);
            }

            MyCustomAttribute attr = (MyCustomAttribute)myType
                                    .GetCustomAttribute(typeof(MyCustomAttribute),false);

            Console.WriteLine("Property1: {0}", attr.Property1);
            Console.WriteLine("Property2: {0}", attr.Property2);
            Console.WriteLine("Property3: {0}", attr.Property3);

            Console.ReadKey();
        }
    }

    [MyCustom(Property1 = true, Property2 = "Hello World", Property3 =MyCustomAttribute.MyCustomAttributeEnum.Red)]
    public class TestReflection {
        public int MyProperty { get; set; }
        public TestReflection() {

        }
        public TestReflection(int i) {

        }
    }

    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    class MyCustomAttribute : System.Attribute {
        public enum MyCustomAttributeEnum {
            Red,
            White,
            Blue
        }
        public bool Property1 { get; set; }
        public string Property2 { get; set; }
        public MyCustomAttributeEnum Property3 { get; set; }
    }
}

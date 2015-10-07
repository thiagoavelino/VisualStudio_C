using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter9 {

    [Serializable]
    class PersontestIO {
        private int _id;
        public string FirstName;
        public string LastName;
        public void SetId(int id) {
            _id = id;
        }
    }

    class IOExamples {
        static void MainIOExamples() {
            //FileInfo file = new FileInfo(@"C:\Users\Thiago\Desktop\test.txt");
            //Console.WriteLine(file.Name);
            //Console.WriteLine(file.DirectoryName);
            ////DirectoryInfo
            //DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\");
            ////Files
            //Console.WriteLine("Files");
            //foreach(FileInfo fileInfo in directoryInfo.GetFiles()) {
            //    Console.WriteLine(fileInfo.Name);
            //}
            ////Directories
            //Console.WriteLine("Directories");
            //foreach(DirectoryInfo di in directoryInfo.GetDirectories()) {
            //    Console.WriteLine(di.Name);
            //}

            //FileStream fileStream = new FileStream(@"C:\Users\Thiago\Desktop\testttt.txt",
            //            FileMode.Append, FileAccess.Write, FileShare.None);
            //for(int i = 0; i < 10; i++) {
            //    byte[] number = new UTF8Encoding(true).GetBytes(i.ToString());
            //    fileStream.Write(number, 0, number.Length);
            //}
            //fileStream.Close();

            //using(var sr = new StreamReader(@"C:\Users\Thiago\Desktop\testttt.txt")){
                
            //    while(!sr.EndOfStream) {
            //        Console.Write((char)sr.Read());
            //    }
            //}

            //using(var sr = new StringReader("test\ntest2")) {
            //    int pos  = sr.Read();
            //    while(pos != -1) {
            //        Console.Write("{0}",(char)pos);
            //        pos = sr.Read();
            //    }
            //}
            PersontestIO person = new PersontestIO();
            person.SetId(1);
            person.FirstName = "Joe";
            person.LastName = "Smith";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Person.bin", FileMode.Create, FileAccess.Write,
            FileShare.None);
            formatter.Serialize(stream, person);
            stream.Close();

            stream = new FileStream("Person.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            PersontestIO person2 = (PersontestIO)formatter.Deserialize(stream);


            stream.Close();
            Console.WriteLine(person2.FirstName);

            Console.Read();
        }
    }
}

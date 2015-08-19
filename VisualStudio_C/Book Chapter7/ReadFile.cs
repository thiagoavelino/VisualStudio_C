using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class ReadFile {
        public const int NumberOfIterations = 24500;
        public static void MainReadFile(string[] args) {
            //handler.GenerateFiles(100000);
            int sum = 0;
            

            Console.WriteLine(DateTime.Now.ToString());
            Parallel.For(0,NumberOfIterations,i=>{
                sum += FileHandler.ReadNumberOnTheFirstLineOfTheFile(String.Format(@"testFiles\MyTest{0}.txt", i));
            });
            //sum = DoingAsyncUsingTasks(sum);
            //sum = DoingSequential(handler, sum);
           // handler.GenerateFiles(NumberOfIterations);
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        private static int DoingAsyncUsingTasks(int sum) {
            Task<int>[] tasks = new Task<int>[NumberOfIterations];
            for(int i = 0; i < NumberOfIterations; i++) {
                tasks[i] = Task.Run(() => FileHandler.ReadNumberOnTheFirstLineOfTheFile(String.Format(@"testFiles\MyTest{0}.txt", i)));
            }
            Task.WaitAll(tasks);
            foreach(var task in tasks) {
                sum += task.Result;
            }
            return sum;
        }

        private static int DoingSequential(FileHandler handler, int sum) {
            for(int i = 0; i < NumberOfIterations; i++) {
                sum += FileHandler.ReadNumberOnTheFirstLineOfTheFile(
                                        String.Format(@"testFiles\MyTest{0}.txt", i));
            }
            return sum;
        }
    }

    class FileHandler {
        public FileHandler() {

        }

        public static int ReadNumberOnTheFirstLineOfTheFile(string path) {
            if(File.Exists(path)) {
                using(StreamReader sr = File.OpenText(path)) {
                    return Int32.Parse(sr.ReadLine());
                }
            } else { 
                return 0;
            }
        }

        public void GenerateFiles(int numberOfFiles) {
            for(int i = 0; i < numberOfFiles; i++) {
                try {
                    string path = String.Format(@"testFiles\MyTest{0}.txt", i);

                    using(FileStream fs = File.Create(path)) {
                        Byte[] info = new UTF8Encoding(true).GetBytes(String.Format("{0}", i));
                        fs.Write(info, 0, info.Length);
                    }
                } catch(Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
                Console.WriteLine("File #{0} created!", i);
            }
        }
    }
}
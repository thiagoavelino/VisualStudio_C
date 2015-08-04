using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter6 {

    public enum WorkType {
        GotoMeetings,
        Golf,
        GenerateReports
    }
    public delegate int WorkPerformedHandler2(int hours, WorkType worktype);

    public delegate int BizRulesDelegate(int x, int y);

    public class DelegateExample {
        static void MainDelegate(string[] args) {
            {
                Func<float, float> result = (float x) => x * x;
            }
            {
                var custs = new List<Customer>{
                    new Customer{City = "Phoenix", FirstName="John", LastName = "Doe", ID =1},
                    new Customer{City = "Phoenix", FirstName="Jane", LastName = "Doe", ID =500},
                    new Customer{City = "Seattle", FirstName="Suki", LastName = "Pizzor", ID =3},
                    new Customer{City = "New York City", FirstName="Michelle", LastName = "Smith", ID =4}
                };
                var phxCusts = custs
                    .Where(c => c.City == "Phoenix")
                    .OrderBy( c=>c.FirstName);
                foreach(var item in phxCusts) {
                    Console.WriteLine(item.FirstName);
                }
                Console.Read();
            }
            {
                BizRulesDelegate addDel = (x, y) => x + y;
                BizRulesDelegate multiply = (x, y) => x * y;
                var data = new ProcessData();
                data.Process(2, 3, addDel);

                Func<int, int, int> funcAddDel = (x, y) => x + y;
                Func<int, int, int> funcMultiply = (x, y) => x * y;
                data.ProcessFunc(3, 2, funcAddDel);

                Action<int,int> myAction = (x,y) => Console.WriteLine(x + y);
                Action<int,int> myMultiplyAction = (x, y) => Console.WriteLine(x*y);

                data.ProcessAction(2, 3, myMultiplyAction);
                Console.Read();
            }
            {
                var worker = new Worker();
                worker.WorkPerformed += (s, e) => Console.WriteLine("Hours Worked {0} {1}", e.Hours, e.WorkType);
                worker.WorkCompleted += (s, e) => Console.WriteLine("Work is Done");
                worker.DoWork(8, WorkType.GenerateReports);
                Console.Read();
            }
            {
                WorkPerformedHandler2 del1 = new WorkPerformedHandler2(WorkPerformed1);
                WorkPerformedHandler2 del2 = new WorkPerformedHandler2(WorkPerformed2);
                WorkPerformedHandler2 del3 = new WorkPerformedHandler2(WorkPerformed3);

                del1 += del2 + del3;

                int finalHours = del1(10, WorkType.GenerateReports);

                Console.WriteLine(finalHours);
                Console.Read();
            }
        }
        
        static void DoWork(WorkPerformedHandler2 del) {
            del(5, WorkType.GotoMeetings);
        }
        static int WorkPerformed1(int hours, WorkType workType) {
            Console.WriteLine("WorkPerformed1 called"+ hours.ToString());
            return hours + 1;
        }
        static int WorkPerformed2(int hours, WorkType workType) {
            Console.WriteLine("WorkPerformed2 called" + hours.ToString());
            return hours + 3;
        }
        static int WorkPerformed3(int hours, WorkType workType) {
            Console.WriteLine("WorkPerformed3 called" + hours.ToString());
            return hours + 3;
        }
    }
}

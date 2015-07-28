using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter5 {

    public class Student : IComparable, IEquatable<Student>, ICloneable {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj) {
            if(!(obj is Student)) {
                throw new ArgumentException("Object is not a Student");
            } else {
                var student = obj as Student;
                return this.Firstname.CompareTo(student.Firstname);
            }
        }

        public bool Equals(Student other) {
            return ((Firstname == other.Firstname) && (Lastname == other.Lastname));
        }

        public object Clone() {
            var student = new Student { Firstname = this.Firstname,
                                        Lastname = this.Lastname,
                                        Age = this.Age
            };
            return student;
        }
    }

    public class StudentComparer : IComparer<Student> {

        public int Compare(Student x, Student y) {
            return x.Firstname.CompareTo(y.Firstname);
        }
    }

    class CommonInterfacesImplementing {
        static void MainCommonInterfaces(string[] args) {

            //IComparable
            Console.WriteLine();
            Console.WriteLine("IComparable");
            {
                var listStudents = new List<Student>{
                    new Student{Firstname = "Rafael", Lastname = "Silva", Age=6},
                    new Student{Firstname = "Rodrigo", Lastname = "Ferreira", Age=6},
                    new Student{Firstname = "Juca", Lastname = "Alves", Age=6},
                    new Student{Firstname = "Alex", Lastname = "Oliveira", Age=6}
                };
                listStudents.Sort();
                foreach(var student in listStudents) {
                    Console.WriteLine(student.Firstname);
                }
            }
            Console.ReadKey();

            //IComparer
            Console.WriteLine();
            Console.WriteLine("IComparer");
            {
                var listStudents = new List<Student>{
                    new Student{Firstname = "Rafael", Lastname = "Silva", Age=6},
                    new Student{Firstname = "Rodrigo", Lastname = "Ferreira", Age=6},
                    new Student{Firstname = "Juca", Lastname = "Alves", Age=6},
                    new Student{Firstname = "Alex", Lastname = "Oliveira", Age=6}
                };
                listStudents.Sort(new StudentComparer());

                foreach(var student in listStudents) {
                    Console.WriteLine("Firstname: {0} Lastname:{1}",student.Firstname,student.Lastname);
                }
            }
            Console.ReadKey();


            //IEquatable
            Console.WriteLine();
            Console.WriteLine("IEquatable");
            {
                var studentA = new Student{Firstname = "Rafael", Lastname = "Silva", Age=6};
                var studentB = new Student { Firstname = "Rafael", Lastname = "Silva", Age = 6 };
                var studentC = new Student { Firstname = "Luiz", Lastname = "Gabardo", Age = 6 };
                if(studentA.Equals(studentB)) {
                    Console.WriteLine("Student A is equal to Student B");
                }

                if(!studentA.Equals(studentC)) {
                    Console.WriteLine("Student A is not equal to Student C");
                }
            }
            Console.ReadKey();

            //IClonable
            Console.WriteLine();
            Console.WriteLine("IClonable");
            {
                var studentA = new Student { Firstname = "Rafael", Lastname = "Silva", Age = 6 };

                var studentB = (Student)studentA.Clone();
                if(studentA.Equals(studentB)) {
                    Console.WriteLine("Student A is equal to Student B");
                    Console.WriteLine("Firstname: {0} Lastname:{1}", studentB.Firstname, studentB.Lastname);
                }

            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Chapter3 {
    class DataStructures {

        public struct Student {

            public string firstName;
            public string lastName;
            public char initial;
            public double score1;
            public double score2;
            public double score3;
            public double score4;
            public double score5;
            public double average;

            // when using constructors, it should call all the members
            public Student(string firstName, string lastName, char initial, double score1, double score2,
                double score3, double score4, double score5, double average) {
                this.firstName = firstName;
                this.lastName = lastName;
                this.initial = initial;
                this.score1 = score1;
                this.score2 = score2;
                this.score3 = score3;
                this.score4 = score4;
                this.score5 = score5;
                this.average = average;
            }

            public void calcAverage() {
                double avg = ((score1 + score2 + score3 + score4 + score5) / 5);
                this.average = avg;
            }
        }

        static void MainDataStructures(string[] args) {
            
            // create a new instance of the Student struct
            Student myStudent = new Student("Thiago", "Avelino",'S',(double)70,(double)75,
                (double)91.4, (double)82.3, (double)67.8, (double)67.8);
            // assign some values to the properties of myStudent
            myStudent.calcAverage();
            Console.Write("Student " + myStudent.firstName + " " + myStudent.lastName);
            Console.Write(" average " + myStudent.average );
            Console.ReadKey();
        }
    }
}

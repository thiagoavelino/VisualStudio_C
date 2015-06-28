using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Chapter3 {
    // an abstract method inside a class
    public abstract class Student {
        public abstract void outputDetails();
    }
    public class CollegeStudent : Student {
        public string firstName;
        public string lastName;
        public string major;
        public double GPA;
        public override void outputDetails() {
            Console.WriteLine("Student " + firstName + " " + lastName +
            " enrolled in " + major + " is has a GPA of " + GPA);
        }
    }
    class AbstractClasses {
        static void MainAbstractClasses(string[] args) {
            var collegeStudent = new CollegeStudent();
            collegeStudent.firstName = "Thiago";
            collegeStudent.lastName = "Avelino";
            collegeStudent.major = "Computer Engineer";
            collegeStudent.GPA = 12.4;
            collegeStudent.outputDetails();
            Console.ReadKey();

        }
    }
}

using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.StackOverFlow.NHibernate {
    public class Example {
        static void Main(string[] args) {
            using(ISession session = NHibernateHelper.OpenSession()) {
                var students = session.CreateCriteria<Student>()
                                 .SetMaxResults(30)
                                 .Future<Student>();
                foreach(var student in students) {
                    Console.WriteLine(student.Name);
                }
                Console.ReadKey();
            }
                
            
        }
    }
}

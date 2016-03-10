using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter9 {
    class CustomCollections {
        static void MainCollections() {
            //PersonCollection persons = new PersonCollection();
            //persons.Add(new Person() {
            //PersonId = 1,
            //FName = "John",
            //LName = "Smith" });
            //persons.Add(new Person()
            //{
            //PersonId = 2,
            //FName = "Jane",
            //LName = "Doe"
            //});
            //persons.Add(new Person() {
            //    PersonId = 3,
            //    FName = "Bill Jones",
            //    LName = "Smith"
            //});
            //foreach(Person person in persons) {
            //    Console.WriteLine(person.FName);
            //}
            var list = new Stack<int>();
            list.Push(1);
            Console.WriteLine(list);
            Console.ReadKey();
        }
    }

    public class Person {
        public int PersonId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class PersonCollection : CollectionBase {
        public void Add(Person person) {
            List.Add(person);
        }
        public void Insert(int index, Person person) {
            List.Insert(index, person);
        }
        public void Remove(Person person) {
            List.Remove(person);
        }
        public Person this[int index] {
            get {
                return (Person)List[index];
            }
            set {
                List[index] = value;
            }
        }

    }
}

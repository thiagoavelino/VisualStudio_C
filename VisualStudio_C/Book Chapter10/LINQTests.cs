using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter10 {

    class HomeTown {
        public String City { get; set; }
        public String State { get; set; }
    }

    class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    class LINQTests {

        static void MainLINQTests(){
            //int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenNumbers = from i in myArray
            //                  where i % 2 == 0
            //                  orderby i descending  
            //                  select i;
            //foreach(var item in evenNumbers) {
            //    Console.WriteLine(item);
            //}
            //myArray[1] = 12;
            //foreach(var item in evenNumbers) {
            //    Console.WriteLine(item);
            //}

            //List<HomeTown> hometowns = new List<HomeTown>()
            //{
            //    new HomeTown() { City = "Philadelphia", State = "PA" },
            //    new HomeTown() { City = "Ewing", State = "NJ" },
            //    new HomeTown() { City = "Havertown", State = "PA" },
            //    new HomeTown() { City = "Fort Washington", State = "PA" },
            //    new HomeTown() { City = "Trenton", State = "NJ" }
            //};

            //var orderedHomeTowns = from i in hometowns
            //                       orderby i.State, i.City
            //                       select i;
            //foreach(var item in orderedHomeTowns) {
            //    Console.WriteLine("City: {0} - State: {1}", item.City, item.State);
            //}

            //List<Person> people = new List<Person>() {
            //    new Person() {
            //        FirstName = "John",
            //        LastName = "Smith",
            //        Address1 = "First St",
            //        City = "Havertown",
            //        State = "PA",
            //        Zip = "19084"
            //   },
            //    new Person()
            //        {
            //        FirstName = "Jane",
            //        LastName = "Doe",
            //        Address1 = "Second St",
            //        City = "Ewing",
            //        State = "NJ",
            //        Zip = "08560"
            //   },
            //    new Person()
            //    {
            //        FirstName = "Jack",
            //        LastName = "Jones",
            //        Address1 = "Third St",
            //        City = "Ft Washington",
            //        State = "PA",
            //        Zip = "19034"
            //    }
            //};
            //var peopleAnonymousType = from p in people
            //                          select new {First = p.FirstName, Last = p.LastName };
            //foreach(var item in peopleAnonymousType) {
            //    Console.WriteLine("FirstName: {0} - LastName: {1}",item.First, item.Last);
            //}
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        FirstName = "John",
            //        LastName = "Smith",
            //        StateId = 1
            //    },
            //    new Employee()
            //    {
            //        FirstName = "Jane",
            //        LastName = "Doe",
            //        StateId = 2
            //    },
            //    new Employee()
            //    {
            //        FirstName = "Jack",
            //        LastName = "Jones",
            //        StateId = 3
            //    }
            //};
            //List<State> states = new List<State>()
            //{
            //    new State()
            //    {
            //        StateId = 1,
            //        StateName = "PA"
            //    },
            //    new State()
            //    {
            //        StateId = 2,
            //        StateName = "NJ"
            //    }
            //};

            //var employeeBySate = from e in employees
            //                     join s in states on e.StateId equals s.StateId into employeeGroup
            //                     from item in employeeGroup.DefaultIfEmpty(new State { StateId = 0,
            //                                                                            StateName = ""})
            //                     select new {
            //                         employeeName = String.Format("{0}, {1}", e.LastName, e.FirstName),
            //                         employeeLocation = item.StateName
            //                     };
                                 
            //foreach(var item in employeeBySate) {
            //    Console.WriteLine("Employee name: {0} - Employee State: {1}", item.employeeName, item.employeeLocation);
            //}

            List<FullEmployee> employees = new List<FullEmployee>()
            {
                new FullEmployee()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    City = "Havertown",
                    State = "PA"
                },
                new FullEmployee()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    City = "Ewing",
                    State = "NJ"
                },
                new FullEmployee()
                {
                    FirstName = "Jack",
                    LastName = "Jones",
                    City = "Fort Washington",
                    State = "PA"
                }
            };

            var employeesByState = from e in employees
                                   group e by e.State;
            foreach(var employeeGroup in employeesByState) {
                Console.WriteLine("{0}:{1}",employeeGroup.Key,employeeGroup.Count());
                foreach(var employee in employeeGroup) {
                    Console.WriteLine("   {0}, {1} - Employee State:{2}", employee.LastName,
                                         employee.FirstName,employee.State);
                }
            }
            Console.ReadKey();
        }
    }
    class Employee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StateId { get; set; }
    }
    class FullEmployee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
    class State {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}

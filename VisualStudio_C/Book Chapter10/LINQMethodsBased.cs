using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter10 {
    class LINQMethodsBased {
        static void Main() {
            //int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenNumbers = myArray.Where(i => i % 2 == 0).OrderByDescending(i => i);
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
            //var orderedHometowns = hometowns.OrderBy(h => h.State).ThenBy(h => h.City);
            //foreach(HomeTown hometown in orderedHometowns) {
            //    Console.WriteLine(hometown.City + ", " + hometown.State);
            //}
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    StateId = 1
                },
                new Employee()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    StateId = 2
                },
                new Employee(){
                    FirstName = "John",
                    LastName = "Smith",
                    StateId = 1
                },
                new Employee(){
                    FirstName = "Sue",
                    LastName = "Smith",
                    StateId = 3
                }
            };
            List<State> states = new List<State>()
            {
                new State()
                {
                    StateId = 1,
                    StateName = "PA"
                },
                new State()
                {
                    StateId = 2,
                    StateName = "NJ"
                },
            };

            //var employeeState = employees.SelectMany(e => states.Where(s => s.StateId == e.StateId)
            //                             .Select(s => new { e.FirstName, s.StateName }));
            //var employeeState = employees.Join(states,
            //                                   e => e.StateId,
            //                                   s => s.StateId,
            //                                   (e, s) => new { e.FirstName, s.StateName });

            //var employeeState = employees.GroupJoin(states,
            //                                   e => e.StateId,
            //                                   s => s.StateId,
            //                                   (e, employeegroup) => employeegroup.Select(s => new {
            //                                    Lastname = e.LastName, StateName = s.StateName
            //                                   }).DefaultIfEmpty(new {Lastname = e.LastName, StateName = "Without state"}))
            //                                    .SelectMany(employeegroup => employeegroup);

            //foreach(var item in employeeState) {
            //    Console.WriteLine("{0}, {1}", item.Lastname, item.StateName);
            //}                                                    
            List<FullEmployee> fullemployees = new List<FullEmployee>()
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

            var groupByState = fullemployees.GroupBy(e => e.State);
            foreach(var itemState in groupByState) {
                Console.WriteLine("State: {0} - Total: {1}", itemState.Key, itemState.Count());
                foreach(var itemEmployee in itemState) {
                    Console.WriteLine("   Name: {0}, {1}", itemEmployee.LastName, itemEmployee.FirstName);
                }
            }

            Console.ReadKey();

        }
    }
}

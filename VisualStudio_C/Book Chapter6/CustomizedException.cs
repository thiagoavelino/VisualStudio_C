using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter6 {
    public class Company {
        private string companyName;
        public Company(string name) {
            this.companyName = name;
        }
        public override string ToString() {
            return this.companyName;
        }
    }
    class CustomizedException {
        public static void MainException() {
            Company company1a = new Company("JonTech");
            Company company1b = company1a;
            Company company2 = new Company(company1a.ToString());
            Console.WriteLine("Calling Equals:");
            Console.WriteLine("company1a and company1b: {0}", company1a.Equals(company1b));
            Console.WriteLine("company1a and company2: {0}", company1a.Equals(company2));
        }
    }
}

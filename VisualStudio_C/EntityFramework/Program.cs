using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.EntityFramework {
    class Program {
        public static void MainEntityFramework() {
            GetContacts();
            Console.ReadKey();
        }

        private static void GetContacts() {
            using(var ctx = new SampleEntities()) {
                ctx.Configuration.ProxyCreationEnabled = true;
                ctx.Configuration.LazyLoadingEnabled = false;
                var contacts = from c in ctx.Contact.Include("Address")
                               where c.FirstName == "Robert"
                               select c;
                foreach(var contact in contacts) {
                    Console.WriteLine("{0}, {1}", contact.LastName.TrimEnd(),
                                                    contact.FirstName);
                    foreach(var address in contact.Address)
                        Console.WriteLine("\t Address:{0} {1}", address.Street1, address.Street2);
                }
            }
        }
    }
}

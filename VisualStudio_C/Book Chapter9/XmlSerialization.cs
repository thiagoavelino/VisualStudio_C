using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VisualStudio_C.Book_Chapter9 {
    [Serializable]
    public class PersonXML {
        public int Id { get; set; }
        [XmlElement(IsNullable = true)]
        public string Name { get; set; }
    }
    class XmlSerialization {
        public static void MainXML() {
            var xmlSerializer = new XmlSerializer(typeof(List<PersonXML>));
            Stream fs = new FileStream("test.xml", FileMode.Create);
            var personObject = new List<PersonXML> {
                new PersonXML { Id = 1, Name = "Thiago" },
                new PersonXML { Id = 2 },
                new PersonXML { Name = "Thiago" }
            };
            xmlSerializer.Serialize(fs, personObject);
        }
    }
}

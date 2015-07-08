using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VisualStudio_C.StackOverFlow {

    class MyElement {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class XMLConversion {
        static void MainXMLConversion(string[] args) {
            var stringXml = @"
            <Profiles>
                <Profile>
                    <ID>123</ID>
                    <firstName>Not</firstName>
                    <lastName>Registered</lastName>
                </Profile>
                <Profile>
                    <ID>124</ID>
                    <firstName>Not</firstName>
                    <lastName>Registered</lastName>
                </Profile>
            </Profiles>";

            XDocument xdoc = XDocument.Parse(stringXml);
            var nodes = xdoc.Root.Elements();

            var query = from data in nodes.Descendants("Profiles")
                        where (int)data.Attribute("ID") == 123
                        select new MyElement {
                            ID = (int)data.Attribute("ID"),
                            FirstName = (string)data.Attribute("firstName"),
                            LastName = (string)data.Attribute("lastName"),
                        };
            var list = query.ToList();
            foreach(var item in list) {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadKey();
        }
    }
}

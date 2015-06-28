using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualStudio_C.StackOverFlow;

namespace VisualStudio_C.StackOverFlow.ParsingJason {
    public class ParsingJson {
        static void MainParsingJson(string[] args) {
            string json = @"{
              'page' : 10,
              'errorMessages' : ['Error Message 01','Error Message 02' ],
              'listings' : { 
                   'data': [{
                    'name' : 'The name',
                    'reference__c' : 'ref1234',
                    'region__c' : 'London',
                    'id' : 'id1234',
                    'price_pb__c' : 700000
                  }]
                }
            }";

            JObject jsonObject = JObject.Parse(json);
            IList<JToken> results = jsonObject["listings"]["data"].Children().ToList();

            IList<Property> processedList = new List<Property>();
            foreach (JToken item in results)
            {
                Property propertyItem = JsonConvert.DeserializeObject<Property>(item.ToString());
                processedList.Add(propertyItem);
            }
            //PropertyList propertyList = JsonConvert.DeserializeObject<PropertyList>(json);
            

            //Console.WriteLine(String.Format("Page: {0}",propertyList.Page));
            //foreach(var item in propertyList.ErrorMessages) {
            //    Console.WriteLine(String.Format("Error Message: {0}",item));
            //}
            //Console.WriteLine(String.Format("Properties"));
            //foreach(var item in propertyList.Properties) {
            //    Console.WriteLine(String.Format("name: {0}", item.Name));
            //    Console.WriteLine(String.Format("Reference: {0}", item.Reference));
            //    Console.WriteLine(String.Format("Region: {0}", item.Region));
            //    Console.WriteLine(String.Format("Features: {0}", item.Features));
            //    Console.WriteLine(String.Format("Price: {0}", item.Price));
            //}
            //Console.ReadKey();

//            string json2 = @"{
//              'page' : 0,
//              'errorMessages' : [ ],
//              'listings' : [ 
//                {
//                  'data' : {
//                    'name' : 'The name',
//                    'reference__c' : 'ref1234',
//                    'region__c' : 'London',
//                    'features__c' : 'Garage;Garden;',
//                    'id' : 'id1234',
//                    'price_pb__c' : 700000,
//                  },
//                  'media' : {
//                    'images' : [ 
//                      {
//                        'title' : 'image1',
//                        'url' : 'http://www.domain.com/image1'
//                      }, 
//                      {
//                        'title' : 'image2',
//                        'url' : 'http://www.domain.com/image2'
//                      }
//                    ]
//                  }
//                }
//              ]
//            }";


        }
    }
}

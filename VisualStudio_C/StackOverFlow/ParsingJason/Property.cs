using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.StackOverFlow.ParsingJason {
    public class Property {
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("reference__c")]
        public String Reference { get; set; }
        [JsonProperty("region__c")]
        public String Region { get; set; }
        [JsonProperty("features__c")]
        public IList<String> Features { get; set; }
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("price_pb__c")]
        public Double Price { get; set; }
        [JsonProperty("media")]
        public IList<String> ImagesUrls { get; set; }
    }
}

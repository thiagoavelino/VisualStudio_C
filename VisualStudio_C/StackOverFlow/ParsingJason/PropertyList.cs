using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.StackOverFlow.ParsingJason {
    public class PropertyList {
        [JsonProperty("page")]
        public Int32 Page { get; set; }
        [JsonProperty("errorMessages")]
        public String[] ErrorMessages { get; set; }
        [JsonProperty("listings")]
        public List<Property> Properties { get; set; }
    }
}

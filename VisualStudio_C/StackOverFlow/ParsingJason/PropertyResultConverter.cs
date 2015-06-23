using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.StackOverFlow.ParsingJason {
    public class PropertyResultConverter : JsonConverter {

        public override bool CanConvert(Type objectType) {
            return (objectType == typeof(PropertyResult));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {

            JObject jo = JObject.Load(reader);
            PropertyResult propertyResult = jo.ToObject<PropertyResult>();
            //propertyResult.Properties = jo.SelectToken("listings.data").ToObject<List<Property>>();
            return propertyResult;

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }

    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.StackOverFlow.ParsingJason {
    
    [JsonObject]
    public class Point {
        public int x { get; set; }
        public int y { get; set; }
    }

    [JsonObject]
    public class Polygon : IEnumerable<Point>{
        public List<Point> Vertices { get; set; }
        public AxisAlignedRectangle Envelope { get; set; }

        public IEnumerator<Point> GetEnumerator() {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
        public bool ShouldSerializeEnvelope() {
            return !(this is AxisAlignedRectangle);
        }

    }

    [JsonObject(IsReference = true)]
    public class AxisAlignedRectangle : Polygon {
        public double Left { get; set; }
        
    }

    public class EnvelopePolygonProblem {

        static void MainEnvelopePolygonProblem(string[] args) {
            var listPoints = new List<Point> { new Point { x = 1, y = 2 }, 
                                               new Point { x = 1, y = 3 } };
            var envelope = new AxisAlignedRectangle { Left = 1, Vertices = listPoints };
            var axisAligned = new AxisAlignedRectangle { Left = 10,
                                                         Envelope = envelope,
                                                         Vertices = listPoints};
            
            string json = JsonConvert.SerializeObject(axisAligned, Formatting.Indented);
            Console.WriteLine(json);
            
            Console.Read();
        }

    }
}

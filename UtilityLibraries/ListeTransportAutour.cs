using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class ListeTransportAutour
    {
            public string id { get; set; }
            public string name { get; set; }
            public double lon { get; set; }
            public double lat { get; set; }
            public string zone { get; set; }
            public List<string> lines { get; set; }

        public override string ToString()
        {
            return String.Format(
                "id: {0} ,\n name: {1} ," +
                "\n longitude: {2} ," +
                "\n latitude: {3} ," +
                "\n zone: {4} ,\n lines: {5}",
                 id, name, lon, lat, zone, String.Join(", ", lines)) + "\n";
        }
    }
}

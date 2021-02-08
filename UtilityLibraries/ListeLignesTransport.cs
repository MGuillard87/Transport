using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class ListeLignesTransport
    {
        public string id { get; set; }
        public string gtfsId { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string color { get; set; }
        public string textColor { get; set; }
        public string mode { get; set; }
        public string type { get; set; }

        public override string ToString()
        {
            return String.Format(
                "id: {0} ,\n shortName: {1} ," +
                "\n type: {2} ,",
                
                 id, shortName, type);
        }

    }
}

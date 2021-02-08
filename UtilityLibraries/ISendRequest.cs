using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public interface ISendRequest
    {

        string doRequest(string uriListeTransportAutour);
    }
}

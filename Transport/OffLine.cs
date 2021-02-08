using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Transport
{
    public class OffLine : ISendRequest
    {
        public WebResponse doRequest(string uriListeTransportAutour)
        {
            throw new NotImplementedException();
        }

        public Stream GetResponseStream()
        {
            throw new NotImplementedException();
        }
    }
}

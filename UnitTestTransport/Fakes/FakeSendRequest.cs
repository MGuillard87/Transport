using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport;
using UtilityLibraries;


namespace UnitTestTransport.Fakes
{
    public class FakeSendRequest : ISendRequest
    {
        public string doRequest(string uriListeTransportAutour)
        {
            return "test";
        }
    }
}

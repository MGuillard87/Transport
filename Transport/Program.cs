using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol=SecurityProtocolType.Tls12|SecurityProtocolType.Tls11|
SecurityProtocolType.Tls;

            Data dataLigneTransport = new Data();
            dataLigneTransport.GetLigneTransportAutour.ForEach(Console.WriteLine);
            dataLigneTransport.GetListeLignesTransport.ForEach(Console.WriteLine);
            

            Console.ReadLine();
            


        }
    }
}

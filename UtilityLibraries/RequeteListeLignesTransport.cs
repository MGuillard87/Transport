using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Transport
{
    class RequeteListeLignesTransport
    {
            private string codes = "SEM:12";


            public string genererUrlListeLignesTransport(string codes)
            {
                /* Utilisez String.Format pour insérer la valeur d’un objet, d’une variable ou 
                    d’une expression dans une autre chaîne -> index commence à 0
                */
                string URLListeLignesTransport = string.Format("http://data.mobilites-m.fr/api/routers/default/index/routes?codes={0} ",codes);
                /*Console.WriteLine(URLListeTransportAutour);*/
                return URLListeLignesTransport;
            }

            public string ListeLignesTransport()
            {
                ISendRequest request = new SendRequest();
                string uriListeLignesTransport = this.genererUrlListeLignesTransport(codes);

                string response = request.doRequest(uriListeLignesTransport);
                // Afficher le status
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                return response;
            }
    }
}

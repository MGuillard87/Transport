using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Transport
{
    public class SendRequest : ISendRequest
    {
        public WebResponse doRequest(string donneesUrl)
        {
            // Créer une requête pour l'URL
            WebRequest request = WebRequest.Create(donneesUrl);
            // Obtenir la réponse 
            WebResponse response = request.GetResponse();
            return response;
            // Afficher l'état
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        }
     

    }
}

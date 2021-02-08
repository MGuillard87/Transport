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
        public string doRequest(string donneesUrl)
        {
            // Créer une requête pour l'URL
            WebRequest request = WebRequest.Create(donneesUrl);
            // Obtenir la réponse 
            WebResponse response = request.GetResponse();
            // Récupère le flux contenant le contenu renvoyé par le serveur
            // Ouverture du flux à l'aide d'un StreamReader pour un accès facile          
            // Lecture du contenu
            // Affichage du contenu
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();


            return responseFromServer;
            // Afficher l'état
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        }
     

    }
}

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

            // Créer une requête pour l'URL
            WebRequest request = WebRequest.Create(
             "http://data.mobilites-m.fr/api/linesNear/json?x=5.726898670196533&y=45.1853141784668&dist=400&details=true");
            // Obtenir la réponse 
            WebResponse response = request.GetResponse();
            // Afficher l'état
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Récupère le flux contenant le contenu renvoyé par le serveur
            // Le bloc 'using' garantit que le flux est automatiquement fermé
            using (Stream dataStream = response.GetResponseStream())
            {
                // Ouverture du flux à l'aide d'un StreamReader pour un accès facile
                StreamReader reader = new StreamReader(dataStream);
                // Lecture du contenu
                string responseFromServer = reader.ReadToEnd();
                // Affichage du contenu
                Console.WriteLine(responseFromServer);
                //Arret de la console 
               
            }
            Console.ReadLine();
            // Close the response.
            response.Close();
        }
    }
}

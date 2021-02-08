using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Transport
{
    //class qui générer un url -> la liste de tous les transports autour du campus
    public class RequeteListeTransportAutour
    {
        private string longitudeX = "5.726898670196533";
        private string latitudeY = "45.1853141784668";
        private string distanceAutour = "400";
        

        public string genererUrlListeTransportAutour(string longitudeX, string latitudeY, string distanceAutour)
        {
            /* Utilisez String.Format pour insérer la valeur d’un objet, d’une variable ou 
                d’une expression dans une autre chaîne -> index commence à 0
            */
            string URLListeTransportAutour = string.Format("http://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", longitudeX, latitudeY, distanceAutour);
            /*Console.WriteLine(URLListeTransportAutour);*/
            return URLListeTransportAutour;
        }
        
        public string listeTransportAutour()
        {
            ISendRequest request = new SendRequest();
            string uriListeTransportAutour = this.genererUrlListeTransportAutour(longitudeX, latitudeY, distanceAutour);
            
            string response = request.doRequest(uriListeTransportAutour);
            // Afficher le status
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            return response;
        }



    }
}

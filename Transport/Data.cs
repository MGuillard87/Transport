using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Transport
{
    // classe qui va traiter les données et les passer à la fonction Main()
    public class Data
    {
        // requêtes: Liste des lignes de transport à proximité d'un point
        public List<ListeTransportAutour> LigneTransportAutourDeserialization()
        {
            RequeteListeTransportAutour resqueteListeAutour = new RequeteListeTransportAutour();
            WebResponse reponse = resqueteListeAutour.listeTransportAutour();
            // Récupère le flux contenant le contenu renvoyé par le serveur
            // Ouverture du flux à l'aide d'un StreamReader pour un accès facile          
            // Lecture du contenu
            // Affichage du contenu
            Stream dataStream = reponse.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
/*            Console.WriteLine(responseFromServer);
            Console.ReadLine();*/
            List<ListeTransportAutour> data = JsonConvert.DeserializeObject<List<ListeTransportAutour>>(responseFromServer);
            return data;
        }


        // requêtes: Liste sur les lignes de transport
        public List<ListeLignesTransport> ListeLignesTransportDeserialization()
        {
            RequeteListeLignesTransport resqueteDescriptionLigneTransport = new RequeteListeLignesTransport();
            WebResponse reponse = resqueteDescriptionLigneTransport.ListeLignesTransport();
            // Récupère le flux contenant le contenu renvoyé par le serveur
            // Ouverture du flux à l'aide d'un StreamReader pour un accès facile          
            // Lecture du contenu
            // Affichage du contenu
            Stream dataStream = reponse.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
/*            Console.WriteLine(responseFromServer);
            Console.ReadLine();*/
            List<ListeLignesTransport> data = JsonConvert.DeserializeObject<List<ListeLignesTransport>>(responseFromServer);
            return data;
        }




        public List<ListeTransportAutour> GetLigneTransportAutour
        {
            get { return LigneTransportAutourDeserialization(); }
            
        }

        public List<ListeLignesTransport> GetListeLignesTransport
        {
            get { return ListeLignesTransportDeserialization(); }

        }


    }

}

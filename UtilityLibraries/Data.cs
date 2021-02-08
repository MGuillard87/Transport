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
            ISendRequest sendRequest = new SendRequest();
            RequeteListeTransportAutour resqueteListeAutour = new RequeteListeTransportAutour(sendRequest);
            string reponse = resqueteListeAutour.listeTransportAutour();
            
/*            Console.WriteLine(responseFromServer);
            Console.ReadLine();*/
            List<ListeTransportAutour> data = JsonConvert.DeserializeObject<List<ListeTransportAutour>>(reponse);
            return data;
        }


        // requêtes: Liste sur les lignes de transport
        public List<ListeLignesTransport> ListeLignesTransportDeserialization()
        {
            RequeteListeLignesTransport resqueteDescriptionLigneTransport = new RequeteListeLignesTransport();
            string reponse = resqueteDescriptionLigneTransport.ListeLignesTransport();
/*            Console.WriteLine(responseFromServer);
            Console.ReadLine();*/
            List<ListeLignesTransport> data = JsonConvert.DeserializeObject<List<ListeLignesTransport>>(reponse);
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

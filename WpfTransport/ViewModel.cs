using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfTransport
{
    sealed class ViewModel : INotifyPropertyChanged
    {

        private Localisation localisation;

        public string Id
        {
            get { return localisation.Id; }
            set
            {
                if (localisation.Id != value)
                {
                    localisation.Id = value;
                    ChangementDePropriete("Id");
                    // Si l'id a changé, la propriété UnePosition doit également être mise à jour
                    ChangementDePropriete("UnePosition");
                }
            }
        }

        public string Name
        {
            get { return localisation.Name; }
            set
            {
                if (localisation.Name != value)
                {
                    localisation.Name = value;
                    ChangementDePropriete("Name");
                    // Si le nom a changé, la propriété UnePosition doit également être mise à jour
                    ChangementDePropriete("UnePosition");
                }
            }
        }

        public string Longitude
        {
            get { return localisation.Longitude; }
            set
            {
                if (localisation.Longitude != value)
                {
                    localisation.Longitude = value;
                    ChangementDePropriete("Longitude");
                    // Si la longitude a changé, la propriété FullName doit également être mise à jour
                    ChangementDePropriete("UnePosition");
                }
            }
        }

        public string Latitude
        {
            get { return localisation.Latitude; }
            set
            {
                if (localisation.Latitude != value)
                {
                    localisation.Latitude = value;
                    ChangementDePropriete("Latitude");
                    // Si la latitude a changé, la propriété FullName doit également être mise à jour
                    ChangementDePropriete("UnePosition");
                }
            }
        }

        public string Zone
        {
            get { return localisation.Zone; }
            set
            {
                if (localisation.Zone != value)
                {
                    localisation.Zone = value;
                    ChangementDePropriete("Zone");
                    // Si la zone a changé, la propriété FullName doit également être mise à jour
                    ChangementDePropriete("UnePosition");
                }
            }
        }

        public string UnePosition
        {
            get { return string.Format("{0},{1},{2},{3},{4}", Id, Name, Longitude, Latitude, Zone); }
        }

        public ViewModel()
        {
            localisation = new Localisation
            {
                Id = "SEM:1986",
                Name = "Grenoble, Caserne de Bonne",
                Longitude = "5.726898670196533",
                Latitude = "45.1853141784668",
                Zone = "SEM_GENCASBONNE"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ChangementDePropriete(string nomPropriete)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nomPropriete));
            }
        }
    
    }
}

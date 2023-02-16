using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commerciale
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int date_Naiss;
        private Categorie catCom;
        private Service service;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Date_Naiss { get => date_Naiss; set => date_Naiss = value; }
        internal Categorie CatCom { get => catCom; set => catCom = value; }
        internal Service Service { get => service; set => service = value; }

        public Commercial(string nom, string prenom, int DN, Categorie com, Service serv)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Date_Naiss = DN;
            this.CatCom = com;
            this.Service = serv;
            this.Service.ajouterCom(this);
        }

        public Commercial()
        {

        }

        public int calculAge()
        {
            int dif;
            dif = DateTime.Now.Year - Date_Naiss;
            return dif;
        }

        public override string ToString()
        {
            return "nom : " + this.Nom + "\nprenom : " + this.Prenom + "\ndate de naissance : " + this.Date_Naiss + " \nCe commercial a donc " + calculAge() + " ans." + this.CatCom;
        }

        public string compare(Commercial other) 
        {
            string message;
            if( this.Nom == other.Nom )
            {
                message = "Les deux commerciaux ont bien le même nom !";
            }
            else
            {
                message = "Les deux commerciaux n'ont pas le même nom !";
            }
            return message;
        }
    }
}

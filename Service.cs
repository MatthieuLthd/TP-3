using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commerciale
{
    internal class Service
    {
        private string nomService;
        private Commercial[] commerciaux;
        private int effectif;

        public string NomService { get => nomService; set => nomService = value; }
        internal Commercial[] Commerciaux { get => commerciaux; set => commerciaux = value; }
        public int Effectif { get => effectif; set => effectif = value; }

        public Service(string nom)
        {
            this.NomService = nom;
            this.Commerciaux = new Commercial[10];
            this.Effectif = 0;
        }

        internal void ajouterCom(Commercial c)
        {
            if (Effectif < Commerciaux.Length)
            {
                Commerciaux[Effectif] = c;
                Effectif++;
            }
            else
            {
                Console.WriteLine("Le tableau de commerciaux est plein.");
            }
        }

        public void afficherCommerciaux()
        {
           Console.WriteLine("\nListe des commerciaux dans le service " + this.NomService);
            foreach(Commercial c in this.commerciaux)
            {
                if (c != null)
                    Console.WriteLine("\n" + c);
            }
        }


        public Commercial plusAge()
        {
            Commercial commercialPlusAge = null;
            int agePlusGrand = 0;
            foreach (Commercial commercial in commerciaux)
            {
                if (commercial != null)
                {
                    int age = commercial.calculAge();
                    if (age > agePlusGrand)
                    {
                        commercialPlusAge = commercial;
                        agePlusGrand = age;
                    }
                }
            }
            Console.WriteLine("\nLe commercial le plus âgé du service " + nomService + " est : " + commercialPlusAge.Nom + " " + commercialPlusAge.Prenom);
            
            return commercialPlusAge;
        }


    }
}

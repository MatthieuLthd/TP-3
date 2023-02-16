// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Commerciale;

namespace Gestion_Commerciale
{
    class program
    {
        static void Main(string[] args)
        {
            // ------------- Création des objets ------------- //

            Categorie cat1 = new Categorie("159", "salarié");
            Categorie cat2 = new Categorie("168", "indépendant");
            Service serv1 = new Service("National");
            Service serv2 = new Service("International");
            Commercial Com1 = new Commercial("Jantres", "Grégouin", 2004, cat1, serv2);
            Commercial Com2 = new Commercial("Jantres", "Scizouin", 2002, cat2, serv1);
            Commercial Com3 = new Commercial("Alfrane", "Jochuan", 1965, cat1, serv2);
            Commercial Com4 = new Commercial("Ingvard", "Panpile", 1968, cat2, serv1);
            Commercial Com5 = new Commercial("Gurvane", "Pipelin", 1990, cat1, serv2);
            Commercial Com6 = new Commercial("Gagètte", "Didière", 1988, cat2, serv1);


            // ------------- Affichage ------------- //

            Console.WriteLine(Com1);
            Console.WriteLine("\n\n");
            Console.WriteLine(Com2);
            Console.WriteLine("\n");
            Console.WriteLine(Com1.compare(Com2));
            Console.WriteLine("\n");
            Console.WriteLine(Com3);
            Console.WriteLine("\n\n");
            Console.WriteLine(cat1);
            Console.WriteLine("\n");
            Console.WriteLine(cat2);
            serv1.afficherCommerciaux();
            serv1.plusAge();
            Console.ReadLine();
        }

    }
}

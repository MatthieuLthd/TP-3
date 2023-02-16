using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commerciale
{
    class Categorie
    {
        private string codeCategorie;
        private string libCategorie;

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        public Categorie(string CC, string LC)
        {
            this.codeCategorie = CC;
            this.libCategorie = LC;
        }

        public Categorie()
        {

        }

        public override string ToString()
        {
            return "\n\nVoici les infos du commercial :" + "\n\nCode de categorie : " + this.CodeCategorie + "\nLe libellé est : " + this.LibCategorie;
        }



    }
}

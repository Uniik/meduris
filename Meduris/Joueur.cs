using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meduris
{
    class Joueur
    {
        private string nom;
        private int laine = 0;
        private int bois = 0;
        private int pierre = 0;
        private int cuivre = 0;

        public Joueur(string nom)
        {
            this.nom = nom;
        }
    }
}

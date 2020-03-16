using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meduris
{
    class HautPlateau
    {
        private int joueur;
        private int typeID;
        private Ouvrier[] ouvriers = new Ouvrier[3];
        public enum Type
        {
            laine = 0,
            bois = 1,
            pierre = 2,
            cuivre = 3
        }

        public HautPlateau(int joueur, Type type)
        {
            this.joueur = joueur;
            this.typeID = (int)type;
        }
    }
}

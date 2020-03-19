using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meduris
{
    public class HautPlateau
    {
        private Point point;
        private int typeID;
        private List<Ouvrier> ouvriers = new List<Ouvrier>();

        public Point Point { get => point; set => point = value; }
        internal List<Ouvrier> Ouvriers { get => ouvriers; set => ouvriers = value; }
        public int TypeID { get => typeID; set => typeID = value; }

        public enum Type
        {
            laine = 0,
            bois = 1,
            pierre = 2,
            cuivre = 3
        }

        public HautPlateau(Point point, Type type)
        {
            this.point = point;
            this.typeID = (int)type;
        }


        public bool ajouterOuvrier(Joueur joueur)
        {
            Ouvrier nouveau = new Ouvrier(joueur);
            if (ouvriers.Count < 3)
            {
                if (joueur.Ouvriers.Count < 3)
                {
                    ouvriers.Add(nouveau);
                    joueur.Ouvriers.Add(nouveau);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}

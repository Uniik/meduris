using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meduris
{
    /// <summary>
    /// 
    /// </summary>
    class Ouvrier
    {
        private int positionID;
        private int hauteur;
        private int joueur;
        public enum Position
        {
            laine = 0,
            bois = 1,
            pierre = 2,
            cuivre = 3
        }
        public static Image[] images = 
        {
            Properties.Resources.meeple_bleu,
            Properties.Resources.meeple_rouge,
            Properties.Resources.meeple_vert
        };

        public int position { get => positionID; set => positionID = value; }
        public int Hauteur { get => hauteur; set => hauteur = value; }

        public Ouvrier(int joueur, int hauteur, Position position)
        {
            this.joueur = joueur;
            this.hauteur = hauteur;
            this.positionID = (int)position;
        }
    }
}

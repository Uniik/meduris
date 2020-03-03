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
        private int position;
        private int hauteur;
        public static Image[] images = 
        {
            Properties.Resources.meeple_bleu,
            Properties.Resources.meeple_rouge,
            Properties.Resources.meeple_vert
        };

        public int Position { get => position; set => position = value; }
        public int Hauteur { get => hauteur; set => hauteur = value; }

        public Ouvrier(int joueur)
        {

        }
    }
}

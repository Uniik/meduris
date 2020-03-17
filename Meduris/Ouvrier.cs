using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    /// <summary>
    /// 
    /// </summary>
    class Ouvrier
    {
        private Joueur joueur;
        private PictureBox image;
        public enum Position
        {
            laine = 0,
            bois = 1,
            pierre = 2,
            cuivre = 3
        }
        public readonly static Image[] images = 
        {
            Properties.Resources.meeple_bleu,
            Properties.Resources.meeple_rouge,
            Properties.Resources.meeple_vert
        };

        public PictureBox Image { get => image; set => image = value; }

        public Ouvrier(Joueur joueur)
        {
            int index = Array.IndexOf(Tasks.Joueurs, joueur);
            image = new PictureBox();
            image.Width = 50;
            image.Height = 50;
            image.Image = images[index];
        }
    }
}

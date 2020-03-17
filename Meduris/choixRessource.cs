using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public partial class ChoixRessource : Form
    {
        private Joueur j;
        private int compteur = 0;
        private string s;
        private bool ajouter; //délaisse une ressource si false
        public ChoixRessource(bool ajouter)
        {
            if (compteur < 3)
            {
                if (ajouter)
                {
                    this.s = "produire";
                }
                else
                {
                    this.s = "délaisser";
                }
                this.ajouter = ajouter;
                j = Tasks.Joueurs[compteur];
                InitializeComponent();
                this.label.Text = j.Nom + ", Choisissez la ressource à " + s;
            }
        }
        private void refresh()
        {
            compteur++;
            if (compteur < 3)
            {
                j = Tasks.Joueurs[compteur];
                this.label.Text = j.Nom + ", Choisissez la ressource à " + s;
            }
            else
            {
                Tasks.tourpart2();
                this.Close();
            }
        }

        private void laineBtn_Click(object sender, EventArgs e)
        {
            ressourceChoisie(0);
        }

        private void BoisBtn_Click(object sender, EventArgs e)
        {
            ressourceChoisie(1);
        }

        private void pierreBtn_Click(object sender, EventArgs e)
        {
            ressourceChoisie(2);
        }

        private void CuivreBtn_Click(object sender, EventArgs e)
        {
            ressourceChoisie(3);
        }

        private void ressourceChoisie(int ressourceID)
        {
            if (ajouter)
            {
                Tasks.produireMP(j, ressourceID);
            }
            else
            {
                Tasks.delaisserMP(j, ressourceID);
            }
            refresh();
        }
    }
}

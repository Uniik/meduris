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

        public int Compteur { get => compteur; set => compteur = value; }

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
            if (j.Laine > 0 || ajouter)//empeche que le joueur aie -1 ressource
            {
                ressourceChoisie(0);
            }
        }

        private void BoisBtn_Click(object sender, EventArgs e)
        {
            if (j.Bois > 0 || ajouter)
            {
                ressourceChoisie(1);
            }
        }

        private void pierreBtn_Click(object sender, EventArgs e)
        {
            if (j.Pierre > 0 || ajouter)
            {
                ressourceChoisie(2);
            }
        }

        private void CuivreBtn_Click(object sender, EventArgs e)
        {
            if (j.Cuivre > 0 || ajouter)
            {
                ressourceChoisie(3);
            }
        }

        private void ressourceChoisie(int ressourceID)
        {
            if (ajouter)
            {
                Tasks.produireMP(j, ressourceID, 1);
            }
            else
            {
                Tasks.delaisserMP(j, ressourceID, 1);
            }
            refresh();
        }
    }
}

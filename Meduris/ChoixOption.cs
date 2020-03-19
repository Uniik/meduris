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
    public partial class ChoixOption : Form
    {
        private Joueur j;
        private int compteur = 0;
        public ChoixOption()
        {
            j = Tasks.Joueurs[compteur];
            InitializeComponent();
            this.label.Text = j.Nom + ", choisissez l'action à éffectuer";
        }

        public void refresh()
        {
            compteur++;
            if(compteur < 3)
            {
                j = Tasks.Joueurs[compteur];
                this.label.Text = j.Nom + ", choisissez l'action à éffectuer";
                this.Visible = true;
            }
            else
            {
                this.Close();
                Tasks.tourpart1();
            }
        }

        private void GrandeExploitation_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Tasks.grandeExploitationPart1(j);
        }

        private void ConstruireHutte_Click(object sender, EventArgs e)
        {
            if(j.HuttesDisponibles > 0)
            {
                if (assezRessources())
                {
                    this.Visible = false;
                    Tasks.achatHutte(j);
                }
            }
        }

        private void ConstruireTemple_Click(object sender, EventArgs e)
        {
            if(j.TemplesDisponibles > 0)
            {
                if (assezRessources())
                {
                    this.Visible = false;
                    Tasks.achatTemple(j);
                }
            }
        }

        private bool assezRessources()
        {
            int total;
            if ((total = j.Laine + j.Bois + j.Pierre + j.Cuivre) > 1)
            {
                if(total != j.Laine && total != j.Bois && total != j.Pierre && total != j.Cuivre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

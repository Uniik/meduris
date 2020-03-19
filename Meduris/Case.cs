using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public class Case
    {
        private Point point;
        private Joueur proprietaire = null;
        private PictureBox image;
        private int typeID = 0; // 0 = vide 1 = hutte 2 = temple
        private int districtID;
        private int coutInitialLaine = 0;
        private int coutInitialBois = 0;
        private int coutInitialPierre = 0;
        private int coutInitialCuivre = 0;
        private int coutLaine = 0;
        private int coutBois = 0;
        private int coutPierre = 0;
        private int coutCuivre = 0;
        public enum Type
        {
            vide = 0,
            hutte = 1,
            temple = 2
        }

        public enum Ressource
        {
            Laine = 0,
            bois = 1,
            pierre = 2,
            cuivre = 3
        }

        public readonly static Image[] imagesHuttes =
        {
            Properties.Resources.hutte_bleu,
            Properties.Resources.hutte_rouge,
            Properties.Resources.hutte_vert
        };

        public readonly static Image[] imagesTemple =
        {
            Properties.Resources.temple_bleu,
            Properties.Resources.temple_rouge,
            Properties.Resources.temple_vert
        };
        public Case(Point p, int districtID,  Ressource r1, Ressource r2)
        {
            this.point = p;
            this.districtID = districtID;
            initCouts((int)r1);
            initCouts((int)r2);

        }

        public PictureBox initImage(Joueur j)
        {
            int index = Array.IndexOf(Tasks.Joueurs, j);
            image = new PictureBox();
            image.Width = 50;
            image.Height = 50;
            if(this.typeID == 1)
            {
                image.Image = imagesHuttes[index];
            }

            if(this.typeID == 2)
            {
                image.Image = imagesTemple[index];
            }

            return this.image;
        }

        private void initCouts(int i)
        {
            switch (i)
            {
                case 0:
                    coutInitialLaine++;
                    coutLaine++;
                    break;
                case 1:
                    coutInitialBois++;
                    coutBois++;
                    break;
                case 2:
                    coutInitialPierre++;
                    coutPierre++;
                    break;
                case 3:
                    coutInitialCuivre++;
                    coutCuivre++;
                    break;

            }
        }

        public void resetCost()
        {
            coutLaine = coutInitialLaine;
            coutBois = coutInitialBois;
            coutPierre = coutInitialPierre;
            coutCuivre = coutInitialCuivre;
        }

        public string getCost()
        {
            string s = "";
            bool premiere = true;
            if(this.CoutLaine != 0)
            {
                s += coutLaine + "laine(s) ";
                if (premiere)
                {
                    s += "et ";
                    premiere = false;
                }
            }

            if (this.CoutBois != 0)
            {
                s += coutBois + "bois ";
                if (premiere)
                {
                    s += "et ";
                    premiere = false;
                }
            }

            if (this.CoutPierre != 0)
            {
                s += coutPierre + "pierre(s) ";
                if (premiere)
                {
                    s += "et ";
                    premiere = false;
                }
            }

            if (this.CoutCuivre != 0)
            {
                s += coutCuivre + "cuivre(s) ";
                if (premiere)
                {
                    s += "et ";
                    premiere = false;
                }
            }
            return s;
        }

        /// <summary>
        /// augmente les couts en ressource de 1
        /// </summary>
        public void augmenterCout()
        {
            if (this.CoutLaine != 0)
            {
                this.CoutLaine++;
            }
            if (this.CoutBois != 0)
            {
                this.CoutBois++;
            }
            if (this.CoutPierre != 0)
            {
                this.CoutPierre++;
            }
            if (this.CoutCuivre != 0)
            {
                this.CoutCuivre++;
            }
        }


        internal Point Point { get => point; set => point = value; }
        public Point Point1 { get => point; set => point = value; }
        public Joueur Proprietaire { get => proprietaire; set => proprietaire = value; }
        public int TypeID { get => typeID; set => typeID = value; }
        public int DistrictID { get => districtID; set => districtID = value; }
        public int CoutLaine { get => coutLaine; set => coutLaine = value; }
        public int CoutBois { get => coutBois; set => coutBois = value; }
        public int CoutPierre { get => coutPierre; set => coutPierre = value; }
        public int CoutCuivre { get => coutCuivre; set => coutCuivre = value; }
    }
}

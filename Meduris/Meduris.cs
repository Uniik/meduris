﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    public partial class Meduris : Form
    {
        private Bitmap currentscope;
        private Joueur selectedPlayer;
        private Graphics gr;
        private bool poserOuvrier = false;
        private bool poserHutte = false;
        private bool poserTemple = false;
        private bool reprendreOuvrier = false;
        private bool mouseOverPlateau = false;
        readonly Color defaultLogColor = Color.Black;
        readonly Point centre = new Point(539, 527);
        static public readonly Case[] cases = new Case[]
        { new Case (new Point(135, 268), 0, Case.Ressource.Laine, Case.Ressource.cuivre),
            new Case (new Point(192, 209), 0, Case.Ressource.pierre, Case.Ressource.bois),
            new Case (new Point(256, 153), 0, Case.Ressource.Laine, Case.Ressource.cuivre),
            new Case (new Point(329, 116), 0, Case.Ressource.bois, Case.Ressource.cuivre),
            new Case (new Point(407, 88), 0, Case.Ressource.pierre, Case.Ressource.bois),

            new Case (new Point(512, 82), 1, Case.Ressource.bois, Case.Ressource.Laine),
            new Case (new Point(590, 97), 1, Case.Ressource.cuivre, Case.Ressource.Laine),
            new Case (new Point(676, 116), 1, Case.Ressource.bois, Case.Ressource.pierre),

            new Case (new Point(769, 130), 2, Case.Ressource.pierre, Case.Ressource.cuivre),
            new Case (new Point(847, 154), 2, Case.Ressource.Laine, Case.Ressource.pierre),
            new Case (new Point(897, 218), 2, Case.Ressource.cuivre, Case.Ressource.bois),
            new Case (new Point(934, 289), 2, Case.Ressource.cuivre, Case.Ressource.Laine),

            new Case (new Point(954, 384), 3, Case.Ressource.pierre, Case.Ressource.cuivre),
            new Case (new Point(978, 472), 3, Case.Ressource.Laine, Case.Ressource.bois),

            new Case (new Point(986, 575), 4, Case.Ressource.bois, Case.Ressource.cuivre),
            new Case (new Point(952, 657), 4, Case.Ressource.pierre, Case.Ressource.cuivre),
            new Case (new Point(915, 731), 4, Case.Ressource.bois, Case.Ressource.Laine),

            new Case (new Point(878, 814), 5, Case.Ressource.pierre, Case.Ressource.Laine),
            new Case (new Point(837, 882), 5, Case.Ressource.pierre, Case.Ressource.bois),
            new Case (new Point(764, 919), 5, Case.Ressource.Laine, Case.Ressource.cuivre),
            new Case (new Point(687, 943), 5, Case.Ressource.bois, Case.Ressource.pierre), 
            new Case (new Point(604, 963), 5, Case.Ressource.Laine, Case.Ressource.pierre),

            new Case (new Point(493, 950), 6, Case.Ressource.bois, Case.Ressource.cuivre),
            new Case (new Point(409, 930), 6, Case.Ressource.bois, Case.Ressource.Laine),
            new Case (new Point(321, 901), 6, Case.Ressource.cuivre, Case.Ressource.pierre),

            new Case (new Point(243, 853), 7, Case.Ressource.bois, Case.Ressource.pierre),
            new Case (new Point(196, 787), 7, Case.Ressource.Laine, Case.Ressource.bois),
            new Case (new Point(130, 729), 7, Case.Ressource.cuivre, Case.Ressource.Laine),
            new Case (new Point(84, 650), 7, Case.Ressource.cuivre, Case.Ressource.bois),

            new Case (new Point(74, 552), 8, Case.Ressource.Laine, Case.Ressource.pierre),
            new Case (new Point(77, 465), 8, Case.Ressource.pierre, Case.Ressource.cuivre),
            new Case (new Point(95, 374), 8, Case.Ressource.Laine, Case.Ressource.pierre) };

        readonly HautPlateau[] hautPlateaux = new HautPlateau[]
        {
            new HautPlateau(new Point(670, 440), HautPlateau.Type.laine),
            new HautPlateau(new Point(453, 347), HautPlateau.Type.bois),
            new HautPlateau(new Point(370, 607), HautPlateau.Type.pierre),
            new HautPlateau(new Point(610, 669), HautPlateau.Type.cuivre)
        };

        public bool MouseOverPlateau { get => mouseOverPlateau; set => mouseOverPlateau = value; }
        public bool PoserOuvrier { get => poserOuvrier; set => poserOuvrier = value; }
        public Joueur SelectedPlayer { get => selectedPlayer; set => selectedPlayer = value; }

        public HautPlateau[] HautPlateaux => hautPlateaux;

        public bool PoserHutte { get => poserHutte; set => poserHutte = value; }
        public bool ReprendreOuvrier { get => reprendreOuvrier; set => reprendreOuvrier = value; }
        public bool PoserTemple { get => poserTemple; set => poserTemple = value; }

        public Meduris(Joueur[] joueurs)
        {
            InitializeComponent();
            this.Player1Name.Text = joueurs[0].Nom;
            this.Player2Name.Text = joueurs[1].Nom;
            this.Player3Name.Text = joueurs[2].Nom;
        }

        /// <summary>
        /// pour le double tampon, donc une meilleur fluidité
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }


        public void addLog(string text, Color? couleur = null)
        {
            string message;
            if (couleur == null)
            {
                couleur = Color.Black;
            }
            message = text;
            Logs.Text = message + "\r\n" + Logs.Text;
            Logs.Find(message);
            Logs.SelectionColor = (Color)couleur;
        }

        public void scope()
        {
            var endWidth = 300;
            var endHeight = 300;

            var scaleFactor = 3;

            var startWidth = endWidth / scaleFactor;
            var startHeight = endHeight / scaleFactor;

            Bitmap bmp = new Bitmap(startWidth, startHeight);

            gr = plateau.CreateGraphics();
            gr = Graphics.FromImage(bmp);

            var xPos = Math.Max(0, MousePosition.X - (startWidth / 2)); // divide by two in order to center
            var yPos = Math.Max(0, MousePosition.Y - (startHeight / 2));

            gr.CopyFromScreen(xPos, yPos, 0, 0, new Size(endWidth, endWidth));
            if (!Utils.compareBitMap(currentscope, bmp))
            {
                scopePanel.BackgroundImage = bmp;
                currentscope = bmp;
            }
        }

        private void plateau_Click(object sender, EventArgs e)
        {
            Point newPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
            Point ClickedCasePoint = null;
            Point ClickedHautPlateauPoint = null;
            HautPlateau ClickedHautPlateau = null;
            bool OuvrierPosable = true;

            ClickedCasePoint = trouverPoint(newPoint, cases);
            ClickedHautPlateauPoint = trouverPoint(newPoint, hautPlateaux);

            if (ClickedHautPlateauPoint != null)
            {

                //pour poser un ouvrier
                if (poserOuvrier)
                {
                    foreach(HautPlateau h in hautPlateaux)
                    {
                        if(h.Point == ClickedHautPlateauPoint)
                        {
                            if (h.ajouterOuvrier(selectedPlayer))
                            {
                                addPic(trouverPointOuvrier(h), h.Ouvriers.Last<Ouvrier>().Image);
                                h.Ouvriers.Last<Ouvrier>().Image.Click += new System.EventHandler(this.OuvrierPB_Click);
                            }
                            else
                            {
                                Tasks.CompteurOuvrier--;
                                OuvrierPosable = false;
                            }
                        }
                    }

                    poserOuvrier = false;
                    if (Tasks.InitOuvrier)
                    {
                        Tasks.InitialiserOuvriers();
                    }
                    else if(OuvrierPosable)
                    {
                        Tasks.grandeExploitationPart2(selectedPlayer);
                    }

                }
                
            }

            if (ClickedCasePoint != null)
            {
                //pour poser une hutte
                if (poserHutte)
                {
                    foreach (Case c in cases)
                    {
                        if (c.Point == ClickedCasePoint)
                        {
                            if (Tasks.acheterHutte(selectedPlayer, c))
                            {
                                addPic(ClickedCasePoint, c.initImage(selectedPlayer));
                                poserHutte = false;
                            }
                        }
                    }
                }
                //pour poser un temple
                if (PoserTemple)
                {
                    foreach (Case c in cases)
                    {
                        if (c.Point == ClickedCasePoint)
                        {
                            if (Tasks.acheterTemple(selectedPlayer, c))
                            {
                                addPic(ClickedCasePoint, c.initImage(selectedPlayer));
                                poserTemple = false;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Si le joueur doit retirer un ouvrier, le premier ouvrié cliqué lui appartenant
        /// est retiré du plateau
        /// ensuite, le joueur peut placer un nouveau ouvrier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OuvrierPB_Click(object sender, EventArgs e)
        {
            HautPlateau hp = Tasks.trouverAvecPB((PictureBox)sender);
            Ouvrier ouvrier = null;
            bool fin = false;
            int index;
            int distance = 30;
            foreach(Ouvrier o in hp.Ouvriers)
            {
                if (o.Image == (PictureBox)sender)
                {
                    ouvrier = o;
                }
            }
            index = hp.Ouvriers.IndexOf(ouvrier);
            if (reprendreOuvrier && ouvrier.Joueur == selectedPlayer)
            {
                foreach(Ouvrier o in hp.Ouvriers)
                {
                    this.plateau.Controls.Remove(o.Image);
                }

                if(hp.Ouvriers.Count <= 1 || index > hp.Ouvriers.Count - 2)
                {
                    fin = true;
                }

                while(!fin)
                {
                    if(hp.Ouvriers[index + 1] != null)
                    {
                        hp.Ouvriers[index] = hp.Ouvriers[index + 1];
                        if (index < hp.Ouvriers.Count - 2)
                        {
                            index++;
                        }
                        else
                        {
                            fin = true;
                        }
                    }
                }
                hp.Ouvriers.RemoveAt(hp.Ouvriers.Count - 1);
                this.reprendreOuvrier = false;
                this.poserOuvrier = true;
                addLog(selectedPlayer.Nom + ", Placez votre ouvrier", Tasks.CouleursJoueurs[Array.IndexOf(Tasks.Joueurs, selectedPlayer)]);

                foreach (Ouvrier o in hp.Ouvriers)
                {
                    double rapportHomothetie = (hp.Point.getDistance(centre) + distance) / hp.Point.getDistance(centre);
                    double x = rapportHomothetie * (hp.Point.X - centre.X) + centre.X;
                    double y = rapportHomothetie * (hp.Point.Y - centre.Y) + centre.Y;
                    addPic(new Point(Convert.ToInt32(x), Convert.ToInt32(y)), o.Image);
                    distance += 50;
                }

            }
        }

        //pour placer un nouvel ouvrier en haut de la pile
        private Point trouverPointOuvrier(HautPlateau h)
        {
            int distance = 30 + 50 * (h.Ouvriers.Count-1);
            double rapportHomothetie = (h.Point.getDistance(centre) + distance) / h.Point.getDistance(centre); // le druide sera à 50 pixel au dessus de la case
            double x = rapportHomothetie * (h.Point.X - centre.X) + centre.X;
            double y = rapportHomothetie * (h.Point.Y - centre.Y) + centre.Y;
            return new Point(Convert.ToInt32(x), Convert.ToInt32(y));
        }

        private Point trouverPoint(Point newPoint, Object[] objectAvecPoint)
        {
            List<Point> Listepoints = new List<Point>();
            if (objectAvecPoint is HautPlateau[])
            {
                foreach (HautPlateau h in objectAvecPoint)

                {
                    Listepoints.Add(h.Point);
                }
            }
            if(objectAvecPoint is Case[])
            {
                foreach (Case c in objectAvecPoint)
                {
                    Listepoints.Add(c.Point);
                }
            }


            //trouve le point le plus proche

            Point plusProche = Listepoints[0];
            for (int i = 0; i < Listepoints.Count; i++)
            {
                if (Listepoints[i].getDistance(newPoint) < plusProche.getDistance(newPoint))
                {
                    plusProche = Listepoints[i];
                }
            }


            // vérifie que le curseur est dans la case
            if (plusProche.getDistance(newPoint) < 30)
            {
                return plusProche;
            }
            else return null;
        }


        private void addPic(Point p, PictureBox pb)
        {
            pb.Location = new System.Drawing.Point(p.X - pb.Width / 2, p.Y - pb.Width / 2);
            pb.BackColor = Color.Transparent;
            Image i = pb.Image;
            float angle = (float)Math.Atan2(centre.Y - p.Y, centre.X - p.X) * (float)(180 / Math.PI) + 270;
            pb.Image = Utils.RotateImage(i, new PointF((float)i.Width / 2, (float)i.Width / 2), angle);
            this.plateau.Controls.Add(pb);
            this.Refresh();
        }

        /// <summary>
        /// par rapport d'homothétie:
        /// R/r = (x3-x1)/(x2-x1)
        /// R/r* (x2-x1) = x3-x1
        /// R/r* (x2-x1)+x1 = x3
        /// </summary>
        /// <param name="p"></param>
        //private void moveDruid(Point p)
        //{
        //    double rapportHomothetie = (p.getDistance(centre) + 50) / p.getDistance(centre); // le druide sera à 50 pixel au dessus de la case
        //    double x = rapportHomothetie * (p.X - centre.X) + centre.X;
        //    double y = rapportHomothetie * (p.Y - centre.Y) + centre.Y;
        //    //addPic(new Point(Convert.ToInt32(x), Convert.ToInt32(y)), global::Meduris.Properties.Resources.druide_normal, 60);
        //}

        private void Plateau_MouseEnter(object sender, EventArgs e)
        {
            mouseOverPlateau = true;
        }

        private void Plateau_MouseLeave(object sender, EventArgs e)
        {
            mouseOverPlateau = false;
        }

        public void refreshStats()
        {
            this.J1PDV.Text = "Point de victoire: " + Tasks.Joueurs[0].Points;
            this.J1L.Text = Tasks.Joueurs[0].Laine.ToString();
            this.J1B.Text = Tasks.Joueurs[0].Bois.ToString();
            this.J1P.Text = Tasks.Joueurs[0].Pierre.ToString();
            this.J1C.Text = Tasks.Joueurs[0].Cuivre.ToString();
            this.J1H.Text = Tasks.Joueurs[0].HuttesDisponibles.ToString();
            this.J1T.Text = Tasks.Joueurs[0].TemplesDisponibles.ToString();

            this.J2PDV.Text = "Point de victoire: " + Tasks.Joueurs[1].Points;
            this.J2L.Text = Tasks.Joueurs[1].Laine.ToString();
            this.J2B.Text = Tasks.Joueurs[1].Bois.ToString();
            this.J2P.Text = Tasks.Joueurs[1].Pierre.ToString();
            this.J2C.Text = Tasks.Joueurs[1].Cuivre.ToString();
            this.J2H.Text = Tasks.Joueurs[1].HuttesDisponibles.ToString();
            this.J2T.Text = Tasks.Joueurs[1].TemplesDisponibles.ToString();

            this.J3PDV.Text = "Point de victoire: " + Tasks.Joueurs[2].Points;
            this.J3L.Text = Tasks.Joueurs[2].Laine.ToString();
            this.J3B.Text = Tasks.Joueurs[2].Bois.ToString();
            this.J3P.Text = Tasks.Joueurs[2].Pierre.ToString();
            this.J3C.Text = Tasks.Joueurs[2].Cuivre.ToString();
            this.J3H.Text = Tasks.Joueurs[2].HuttesDisponibles.ToString();
            this.J3T.Text = Tasks.Joueurs[2].TemplesDisponibles.ToString();

            this.CompteurTour.Text = "Tour: " + Tasks.Tour;

        }

        private void AfficherLoupeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (this.AfficherLoupeCB.Checked)
            {
                this.scopePanel.Visible = true;
            }
            else
            {
                this.scopePanel.Visible = false;
            }
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

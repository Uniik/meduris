using System;
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
        private Joueur[] joueurs;
        private Joueur selectedPlayer;
        private Graphics gr;
        private bool poserOuvrier = false;
        private bool mouseOverPlateau = false;
        readonly Color defaultLogColor = Color.Black;
        readonly Point centre = new Point(539, 527);
        readonly Case[] cases = new Case[]
        { new Case (new Point(135, 268)), new Case (new Point(192, 209)), new Case (new Point(256, 153)), new Case (new Point(329, 116)),
            new Case (new Point(407, 88)), new Case (new Point(512, 82)), new Case (new Point(590, 97)), new Case (new Point(676, 116)),
            new Case (new Point(769, 130)), new Case (new Point(847, 154)), new Case (new Point(897, 218)), new Case (new Point(934, 289)),
            new Case (new Point(954, 384)), new Case (new Point(978, 472)), new Case (new Point(986, 575)), new Case (new Point(952, 657)),
            new Case (new Point(915, 731)), new Case (new Point(878, 814)), new Case (new Point(837, 882)), new Case (new Point(764, 919)),
            new Case (new Point(687, 943)), new Case (new Point(604, 963)), new Case (new Point(493, 950)), new Case (new Point(409, 930)),
            new Case (new Point(321, 901)), new Case (new Point(243, 853)), new Case (new Point(196, 787)), new Case (new Point(130, 729)),
            new Case (new Point(84, 650)), new Case (new Point(74, 552)), new Case (new Point(77, 465)), new Case (new Point(95, 374)) };
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

        public Meduris(Joueur[] joueurs)
        {
            this.joueurs = joueurs;
            InitializeComponent();
            this.Player1Name.Text = joueurs[0].Nom;
            this.Player2Name.Text = joueurs[1].Nom;
            this.Player3Name.Text = joueurs[2].Nom;
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

            var scaleFactor = 3; //perhaps get this value from a const, or an on screen slider

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
            Point ClickedCase = null;
            Point ClickedHautPlateauPoint = null;
            HautPlateau ClickedHautPlateau = null;

            //ClickedCase = trouverPoint(newPoint, cases);
            ClickedHautPlateauPoint = trouverPoint(newPoint, hautPlateaux);

            if (ClickedHautPlateauPoint != null)
            {
                if (poserOuvrier)
                {
                    foreach(HautPlateau h in hautPlateaux)
                    {
                        if(h.Point == ClickedHautPlateauPoint)
                        {
                            if (h.ajouterOuvrier(selectedPlayer))
                            {
                                addPic(trouverPointOuvrier(h), h.Ouvriers.Last<Ouvrier>().Image);
                            }
                            else
                            {
                                Tasks.CompteurOuvrier--;
                                Console.WriteLine("erreur");
                            }
                        }
                    }

                    poserOuvrier = false;
                    if (Tasks.InitOuvrier)
                    {
                        Tasks.InitialiserOuvriers();
                    }

                }
            }

            if (ClickedCase != null)
            {
            }

            Console.WriteLine("X: " + Cursor.Position.X + "y: " + Cursor.Position.Y);
        }

        private Point trouverPointOuvrier(HautPlateau h)
        {
            Console.WriteLine(h.Ouvriers.Count);
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
        }

        /// <summary>
        /// par rapport d'homothétie:
        /// R/r = (x3-x1)/(x2-x1)
        /// R/r* (x2-x1) = x3-x1
        /// R/r* (x2-x1)+x1 = x3
        /// </summary>
        /// <param name="p"></param>
        private void moveDruid(Point p)
        {
            double rapportHomothetie = (p.getDistance(centre) + 50) / p.getDistance(centre); // le druide sera à 50 pixel au dessus de la case
            double x = rapportHomothetie * (p.X - centre.X) + centre.X;
            double y = rapportHomothetie * (p.Y - centre.Y) + centre.Y;
            //addPic(new Point(Convert.ToInt32(x), Convert.ToInt32(y)), global::Meduris.Properties.Resources.druide_normal, 60);
        }

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

        }

    }
}

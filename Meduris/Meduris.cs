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
        private Graphics gr;
        private bool mouseOverPlateau = false;
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

        public bool MouseOverPlateau { get => mouseOverPlateau; set => mouseOverPlateau = value; }

        public Meduris(Joueur[] joueurs)
        {
            this.joueurs = joueurs;
            InitializeComponent();
            this.Player1Name.Text = joueurs[0].Nom;
            this.Player2Name.Text = joueurs[1].Nom;
            this.Player3Name.Text = joueurs[2].Nom;

        }

        public void addLog(string text)
        {
            Logs.Text = text +"\r\n" + Logs.Text;
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
            Point plusProche = cases[0].Point;
            int test = 0;

            //trouve la case la plus proche
            for(int i =0; i< cases.Length ; i++)
            {
                if (cases[i].Point.getDistance(newPoint) < plusProche.getDistance(newPoint))
                {
                    plusProche = cases[i].Point;
                    test = i;
                }
            }
            // vérifie que le curseur est dans la case
            if(plusProche.getDistance(newPoint) < 30)
            {
                addPic(plusProche, new Bitmap(global::Meduris.Properties.Resources.temple_vert), 50);
                moveDruid(plusProche);
            }

            Console.WriteLine("X: " +Cursor.Position.X +"y: " +Cursor.Position.Y);
        }

        private void addPic(Point p, Image i, int size)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new System.Drawing.Point(p.X-size/2, p.Y-size/2);
            pb.Size = new System.Drawing.Size(size, size);
            pb.BackColor = Color.Transparent;
            float angle = (float)Math.Atan2(centre.Y - p.Y, centre.X - p.X) * (float)(180 / Math.PI) + 270;
            pb.Image = Utils.RotateImage(i, new PointF((float)i.Width / 2, (float)i.Height / 2), angle);
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
            double rapportHomothetie = (p.getDistance(centre) + 50)/p.getDistance(centre); // le druide sera à 50 pixel au dessus de la case
            double x = rapportHomothetie * (p.X - centre.X) + centre.X;
            double y = rapportHomothetie * (p.Y - centre.Y) + centre.Y;
            addPic(new Point(Convert.ToInt32(x), Convert.ToInt32(y)), global::Meduris.Properties.Resources.druide_normal, 60);
        }

        private void Plateau_MouseEnter(object sender, EventArgs e)
        {
            mouseOverPlateau = true;
        }

        private void Plateau_MouseLeave(object sender, EventArgs e)
        {
            mouseOverPlateau = false;
        }

    }
}

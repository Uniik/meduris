using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    static class Tasks
    {
        static private Meduris mainWindow;
        static private Menu menu;
        static private bool initOuvrier = true;
        static private int compteurOuvrier = 0;
        static private Joueur[] joueurs;
        static private Color[] couleursJoueurs = new Color[]
        {
            Color.Blue,
            Color.Red,
            Color.Green

        };
        static private bool dernierTour = false;

        //ouvre le menu d'acceil
        public static void launch()
        {
            menu = new Menu();
            Application.Run(menu);
        }

        //ferme le menu et ouvre le jeu
        public static void startMeduris(string p1, string p2, string p3)
        {
            InitTimer();
            joueurs = new Joueur[] { new Joueur(p1), new Joueur(p2), new Joueur(p3) };
            mainWindow = new Meduris(joueurs);
            menu.Hide();
            mainWindow.Closed += (s, args) => menu.Close();
            mainWindow.Show();
            InitialiserOuvriers();

        }
        public static void InitialiserOuvriers()
        {
            if (compteurOuvrier < 6)
            {
                Console.WriteLine("compteur : " + compteurOuvrier);
                Joueur j;
                String s; //premier ou deuxieme

                if (compteurOuvrier < 3)
                {
                    j = joueurs[compteurOuvrier];
                    s = "premier";
                }
                else
                {
                    j = joueurs[compteurOuvrier - 3];
                    s = "second";
                }

                mainWindow.addLog(j.Nom + ", Placez votre " +s +" ouvrier", couleursJoueurs[Array.IndexOf(joueurs, j)]);
                mainWindow.PoserOuvrier = true;
                mainWindow.SelectedPlayer = j;
                compteurOuvrier ++;
            }
            else
            {
                initOuvrier = false;
                tourpart1();
            }
        }

        public static void tourpart1()
        {
            Random r = new Random();
            mainWindow.addLog("Début du tour:");
            System.Threading.Thread.Sleep(1000);

            switch (r.Next(1, 6))
            {
                case 1:  //chaques joueur doivent délaisser une ressource
                    mainWindow.addLog("Attention: vous devrez choisir une ressource à délaisser.");
                    System.Threading.Thread.Sleep(2000);
                    new ChoixRessource(false).Show();               
                    break;
                case 2:
                    mainWindow.addLog("Attention: vous devrez choisir une ressource à produire.");
                    System.Threading.Thread.Sleep(2000);
                    new ChoixRessource(true).Show();
                    break;
                default:
                    mainWindow.addLog("Attention: Chaques ouvriers ont produit une matière première!");
                    System.Threading.Thread.Sleep(2000);
                    produireMPparOuvrier();
                    break;
            }
        }
        public static void tourpart2()
        {

        }

        public static void delaisserMP(Joueur j, int ID)
        {
            switch (ID)
            {
                case 0:
                    j.Laine--;
                    break;
                case 1:
                    j.Bois--;
                    break;
                case 2:
                    j.Pierre--;
                    break;
                case 3:
                    j.Cuivre--;
                    break;
            }
            mainWindow.refreshStats();
        }

        public static void produireMP(Joueur j, int ID)
        {
            switch (ID)
            {
                case 0:
                    j.Laine++;
                    break;
                case 1:
                    j.Bois++;
                    break;
                case 2:
                    j.Pierre++;
                    break;
                case 3:
                    j.Cuivre++;
                    break;
            }
            mainWindow.refreshStats();
        }
        private static void produireMPparOuvrier()
        {
            foreach(HautPlateau hp in mainWindow.HautPlateaux)
            {
                foreach(Ouvrier o in hp.Ouvriers)
                {
                    produireMP(o.Joueur, hp.TypeID);
                }
            }
            
        }

        static private Timer timer1;

        public static Joueur[] Joueurs { get => joueurs; set => joueurs = value; }
        public static int CompteurOuvrier { get => compteurOuvrier; set => compteurOuvrier = value; }
        public static bool InitOuvrier { get => initOuvrier; set => initOuvrier = value; }

        static public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 25; // in miliseconds
            timer1.Start();
        }

        private static void timer1_Tick(object sender, EventArgs e)
        {
            if (mainWindow.MouseOverPlateau)
            {
                mainWindow.scope();
            }
        }


    }
}

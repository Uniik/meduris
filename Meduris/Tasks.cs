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
        static private ChoixOption choixOption;
        static private bool initOuvrier = true;
        static private int compteurOuvrier = 0;
        static private int tour = 0;
        static private Joueur[] joueurs;
        static private Color[] couleursJoueurs = new Color[]
        {
            Color.Blue,
            Color.Red,
            Color.Green

        };
        //static private bool dernierTour = false;

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

                mainWindow.addLog(j.Nom + ", Placez votre " + s + " ouvrier", couleursJoueurs[Array.IndexOf(joueurs, j)]);
                mainWindow.PoserOuvrier = true;
                mainWindow.SelectedPlayer = j;
                compteurOuvrier++;
            }
            else
            {
                initOuvrier = false;
                tourpart1();
            }
        }

        public static void tourpart1()
        {
            tour++;
            mainWindow.Refresh();
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
            mainWindow.Refresh();
            mainWindow.addLog("Attention: vous devrez choisir une action à éffectuer.");
            System.Threading.Thread.Sleep(2000);
            choixOption = new ChoixOption();
            choixOption.Show();
        }

        /// <summary>
        /// délaisse une matière première et rafraichit les stats dans l'interface
        /// </summary>
        /// <param name="j"></param>
        /// <param name="ID"></param>
        /// <param name="quantite"></param>
        public static void delaisserMP(Joueur j, int ID, int quantite)
        {
            switch (ID)
            {
                case 0:
                    j.Laine -= quantite;
                    break;
                case 1:
                    j.Bois -= quantite;
                    break;
                case 2:
                    j.Pierre -= quantite;
                    break;
                case 3:
                    j.Cuivre -= quantite;
                    break;
            }
            mainWindow.refreshStats();
        }
        /// <summary>
        /// produit une matière première et rafraichit les stats dans l'interface
        /// </summary>
        /// <param name="j"></param>
        /// <param name="ID"></param>
        /// <param name="quantite"></param>
        public static void produireMP(Joueur j, int ID, int quantite)
        {
            switch (ID)
            {
                case 0:
                    j.Laine += quantite;
                    break;
                case 1:
                    j.Bois += quantite;
                    break;
                case 2:
                    j.Pierre += quantite;
                    break;
                case 3:
                    j.Cuivre += quantite;
                    break;
            }
            mainWindow.refreshStats();
        }

        /// <summary>
        /// Le joueurs produit des matières premières
        /// selon la position de leur ouvriers
        /// </summary>
        /// <param name="j"></param>
        public static void grandeExploitationPart1(Joueur j)
        {

            mainWindow.addLog(j.Nom + ", Choisissez l'ouvrier à reprendre", couleursJoueurs[Array.IndexOf(joueurs, j)]);
            mainWindow.SelectedPlayer = j;
            mainWindow.ReprendreOuvrier = true;
        }

        public static void grandeExploitationPart2(Joueur j)
        {
            foreach (HautPlateau hp in mainWindow.HautPlateaux)
            {
                foreach (Ouvrier o in hp.Ouvriers)
                {
                    if (o.Joueur == j)
                    {
                        produireMP(j, hp.TypeID, hp.Ouvriers.IndexOf(o) + 1);
                    }
                }
            }
            choixOption.refresh();
        }
        /// <summary>
        /// produit une matière première par ouvrier
        /// </summary>
        private static void produireMPparOuvrier()
        {
            foreach (HautPlateau hp in mainWindow.HautPlateaux)
            {
                foreach (Ouvrier o in hp.Ouvriers)
                {
                    produireMP(o.Joueur, hp.TypeID, 1);
                }
            }
            tourpart2();

        }

        public static void achatHutte(Joueur j)
        {
            mainWindow.SelectedPlayer = j;
            mainWindow.PoserHutte = true;
            mainWindow.addLog(j.Nom + ", Cliquez sur la case voulue", couleursJoueurs[Array.IndexOf(joueurs, j)]);
        }

        public static void achatTemple(Joueur j)
        {
            mainWindow.SelectedPlayer = j;
            mainWindow.PoserTemple = true;
            mainWindow.addLog(j.Nom + ", Cliquez sur la case voulue", couleursJoueurs[Array.IndexOf(joueurs, j)]);
        }

        public static bool acheterHutte(Joueur j, Case c)
        {
            int compteur = 1;
            int position = Array.IndexOf(Meduris.cases, c);
            bool pasDeHutte = false;
            Case voisin;
            c.resetCost();

            if(c.TypeID != 0)
            {
                mainWindow.addLog(j.Nom + ", cette case est déja occupé!", couleursJoueurs[Array.IndexOf(joueurs, j)]);
                return false;
            }

            //pour compter les huttes à gauche
            while (!pasDeHutte)
            {
                if(position-compteur < 0)
                {
                    voisin = Meduris.cases[Meduris.cases.Length - compteur];
                }
                else
                {
                    voisin = Meduris.cases[position - compteur];
                }
                if(voisin.TypeID == 1)
                {
                    c.augmenterCout();
                    compteur++;
                }
                else
                {
                    pasDeHutte = true;
                }
            }


            compteur = 1;
            pasDeHutte = false;

            // pour compter les huttes à droite
            while (!pasDeHutte)
            {
                if (position + compteur >= Meduris.cases.Length)
                {
                    voisin = Meduris.cases[-1+compteur];
                }
                else
                {
                    voisin = Meduris.cases[position + compteur];
                }
                if (voisin.TypeID == 1)
                {
                    c.augmenterCout();
                    compteur++;
                }
                else
                {
                    pasDeHutte = true;
                }
            }

            //vérifie si le joueur a les fonds suffisant
            if (j.Laine >= c.CoutLaine && j.Bois >= c.CoutBois && j.Pierre >= c.CoutPierre && j.Cuivre >= c.CoutCuivre)
            {

                mainWindow.addLog(j.Nom + ", Vous venez d'acheter une Hutte pour " + c.getCost(), couleursJoueurs[Array.IndexOf(joueurs, j)]);
                j.Laine -= c.CoutLaine;
                j.Bois -= c.CoutBois;
                j.Pierre -= c.CoutPierre;
                j.Cuivre -= c.CoutCuivre;
                j.HuttesDisponibles--;
                c.TypeID = 1;
                c.Proprietaire = j;
                mainWindow.refreshStats();
                choixOption.refresh();
                return true;


            }
            else
            {
                mainWindow.addLog(j.Nom + ", Vous n'avez pas les ressources nécessaires: " + c.getCost(), couleursJoueurs[Array.IndexOf(joueurs, j)]);
                return false;
            }
        }

        public static bool acheterTemple(Joueur j, Case c)
        {
            if(c.TypeID != 0)
            {
                return false;
            }
            if (j.Laine >= c.CoutLaine && j.Bois >= c.CoutBois && j.Pierre >= c.CoutPierre && j.Cuivre >= c.CoutCuivre)
            {

                mainWindow.addLog(j.Nom + ", Vous venez d'acheter un temple pour " + c.getCost(), couleursJoueurs[Array.IndexOf(joueurs, j)]);
                j.Laine -= c.CoutLaine;
                j.Bois -= c.CoutBois;
                j.Pierre -= c.CoutPierre;
                j.Cuivre -= c.CoutCuivre;
                j.HuttesDisponibles--;
                c.TypeID = 2;
                c.Proprietaire = j;
                mainWindow.refreshStats();
                choixOption.refresh();
                return true;
            }
            else
            {
                mainWindow.addLog(j.Nom + ", Vous n'avez pas les ressources nécessaires: " + c.getCost(), couleursJoueurs[Array.IndexOf(joueurs, j)]);
                return false;
            }
        }

        //retourne le hautplateau contenant l'ouvrier à qui appartient la PictureBox
        public static HautPlateau trouverAvecPB(PictureBox pb)
        {
            foreach(HautPlateau hp in mainWindow.HautPlateaux)
            {
                foreach(Ouvrier o in hp.Ouvriers)
                {
                    if(o.Image == pb)
                    {
                        return hp;
                    }
                }
            }
            return null;
        }

        static private Timer timer1;

public static Joueur[] Joueurs { get => joueurs; set => joueurs = value; }
public static int CompteurOuvrier { get => compteurOuvrier; set => compteurOuvrier = value; }
public static bool InitOuvrier { get => initOuvrier; set => initOuvrier = value; }
public static int Tour { get => tour; set => tour = value; }
        public static Color[] CouleursJoueurs { get => couleursJoueurs; set => couleursJoueurs = value; }

        static public void InitTimer()
{
    timer1 = new Timer();
    timer1.Tick += new EventHandler(timer1_Tick);
    timer1.Interval = 25; // in miliseconds
    timer1.Start();
}

       //rafraichit la loupe tout les 25 ms
private static void timer1_Tick(object sender, EventArgs e)
{
    if (mainWindow.MouseOverPlateau)
    {
        mainWindow.scope();
    }
}


    }
}

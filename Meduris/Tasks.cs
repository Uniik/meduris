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
            mainWindow = new Meduris(new Joueur[] { new Joueur(p1), new Joueur(p2), new Joueur(p3) });
            menu.Hide();
            mainWindow.Closed += (s, args) => menu.Close();
            mainWindow.Show();
        }
        public static void poserOuvriers()
        {

        }

        public static void debutTour()
        {
            while (!dernierTour)
            {

            }
        }

        static private Timer timer1;
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

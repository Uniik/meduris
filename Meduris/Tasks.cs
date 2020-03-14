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
        public static void launch()
        {
            menu = new Menu();
            Application.Run(menu);
        }

        public static void startMeduris(string p1, string p2, string p3)
        {
            InitTimer();
            mainWindow = new Meduris(p1, p2, p3);
            menu.Hide();
            mainWindow.Closed += (s, args) => menu.Close();
            mainWindow.Show();
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

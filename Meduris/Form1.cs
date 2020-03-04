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
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private Graphics gr;
        private bool mouseOverPlateau = false;
        readonly Point[] casesPoints = new Point[]
        { new Point(151, 275), new Point(196, 223), new Point(261, 166), new Point(335, 131),
            new Point(407, 102), new Point(510, 93), new Point(591, 109), new Point(674, 124),
            new Point(767, 138), new Point(847, 160), new Point(892, 222), new Point(933, 295),
            new Point(951, 387), new Point(978, 471), new Point(983, 578), new Point(954, 659),
            new Point(919, 734), new Point(877, 817), new Point(834, 883), new Point(767, 912),
            new Point(688, 940), new Point(607, 959), new Point(494, 948), new Point(413, 929),
            new Point(325, 903), new Point(242, 858), new Point(200, 789), new Point(139, 733),
            new Point(92, 655), new Point(78, 557), new Point(86, 468), new Point(107, 379) };

        public Form1()
        {
            InitializeComponent();
        }


        public void scope()
        {
            var endWidth = 300;
            var endHeight = 300;

            var scaleFactor = 3; //perhaps get this value from a const, or an on screen slider

            var startWidth = endWidth / scaleFactor;
            var startHeight = endHeight / scaleFactor;

            bmp = new Bitmap(startWidth, startHeight);

            gr = plateau.CreateGraphics();
            gr = Graphics.FromImage(bmp);

            var xPos = Math.Max(0, MousePosition.X - (startWidth / 2)); // divide by two in order to center
            var yPos = Math.Max(0, MousePosition.Y - (startHeight / 2));

            gr.CopyFromScreen(xPos, yPos, 0, 0, new Size(endWidth, endWidth));
            scopePanel.BackgroundImage = bmp;
        }

        private void plateau_Click(object sender, EventArgs e)
        {
            Console.WriteLine("x: " + Cursor.Position.X + " y: " + Cursor.Position.Y);
        }
    }
}

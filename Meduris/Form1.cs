using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        readonly Point centre = new Point(539, 527);
        readonly Point[] casesPoints = new Point[]
        { new Point(135, 268), new Point(192, 209), new Point(256, 153), new Point(329, 116),
            new Point(407, 88), new Point(512, 82), new Point(590, 97), new Point(676, 116),
            new Point(769, 130), new Point(847, 154), new Point(897, 218), new Point(934, 289),
            new Point(954, 384), new Point(978, 472), new Point(986, 575), new Point(952, 657),
            new Point(915, 731), new Point(878, 814), new Point(837, 882), new Point(764, 919),
            new Point(687, 943), new Point(604, 963), new Point(493, 950), new Point(409, 930),
            new Point(321, 901), new Point(243, 853), new Point(196, 787), new Point(130, 729),
            new Point(84, 650), new Point(74, 552), new Point(77, 465), new Point(95, 374) };

        public Form1()
        {
            InitializeComponent();
            foreach(Point p in casesPoints)
            {
                addPic(p, new Bitmap(global::Meduris.Properties.Resources.temple_vert));
            }
            
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

        private void addPic(Point p, Image i)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new System.Drawing.Point(p.X-25, p.Y-25);
            pb.Size = new System.Drawing.Size(50, 50);
            pb.BackColor = Color.Transparent;
            float test = (float)Math.Atan2(centre.Y - p.Y, centre.X - p.X) * (float)(180 / Math.PI) + 270;
            pb.Image = Utilities.RotateImage(i, new PointF((float)i.Width / 2, (float)i.Height / 2), test);
            this.plateau.Controls.Add(pb);
        }


    }
}

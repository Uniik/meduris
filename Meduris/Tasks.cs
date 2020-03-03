using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meduris
{
    class Tasks
    {
        private Bitmap bmp;
        private Graphics gr;
        public Tasks()
        {

        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var endWidth = 300;
            var endHeight = 300;

            var scaleFactor = 3; //perhaps get this value from a const, or an on screen slider

            var startWidth = endWidth / scaleFactor;
            var startHeight = endHeight / scaleFactor;

            bmp = new Bitmap(startWidth, startHeight);

            gr = this.CreateGraphics();
            gr = Graphics.FromImage(bmp);

            var xPos = Math.Max(0, Form1.MousePosition.X - (startWidth / 2)); // divide by two in order to center
            var yPos = Math.Max(0, Form1.MousePosition.Y - (startHeight / 2));

            gr.CopyFromScreen(xPos, yPos, 0, 0, new Size(endWidth, endWidth));
            Form1.panel5.BackgroundImage = bmp;
        }

        private Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }
}

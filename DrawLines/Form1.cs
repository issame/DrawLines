using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class Form1 : Form
    {
        Pen nPen = new Pen(Color.Black);
        Graphics Canvas = null;
        Bitmap bmp;

        static int start_x, start_y;
        static int end_x, end_y;

        static int angle, increment, nline, length;


        public Form1()
        {
            InitializeComponent();
            start_x = Dessin.Width * 2 / 3;
            start_y = Dessin.Height * 2 / 3;
        }

        private void Dessin_Paint(object sender, PaintEventArgs e)
        {
            nPen.Width = 1;
            Canvas = Dessin.CreateGraphics();
            Canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            for (int i = 0; i < nline; i++)
            {
                DrawCanvas();
            }


        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //start_x = Dessin.Width * 2 / 3;
            //start_y = Dessin.Height * 2 / 3;

            length = int.Parse(txtLength.Text);
            angle = int.Parse(txtAngle.Text);
            increment = int.Parse(txtIncr.Text);
            nline = int.Parse(txtLines.Text);


            Dessin.Refresh();



        }

        private void DrawCanvas()
        {
            angle += int.Parse(txtAngle.Text);
            length += int.Parse(txtIncr.Text);

            end_x = (int)(start_x + length * Math.Cos(angle * Math.PI / 180));
            end_y = (int)(start_y + length * Math.Sin(angle * Math.PI / 180));


            Point[] drawPoints =
            {
                new Point(start_x, start_y),
                new Point(end_x, end_y)
            };



            start_x = end_x;
            start_y = end_y;

            Canvas.DrawLines(nPen, drawPoints);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Dessin.Width, Dessin.Height);

            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = Dessin.RectangleToScreen(Dessin.ClientRectangle);

            g.CopyFromScreen(rect.Location, Point.Empty, Dessin.Size);

            string rnd = Path.GetRandomFileName();

            bmp.Save(rnd.Substring(0, rnd.LastIndexOf(".")) + ".png");

        }

        private void Dessin_Click(object sender, EventArgs e)
        {
            start_x = MousePosition.X;
            start_y = MousePosition.Y;
        }

    }
}

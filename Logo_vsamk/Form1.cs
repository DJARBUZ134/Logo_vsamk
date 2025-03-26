using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo_vsamk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.SteelBlue);
            Pen p = new Pen(Color.Black, 2);
            Pen p1 = new Pen(Color.YellowGreen, 20);
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.AliceBlue);
            // правые линии
            int x = 970;
            int xs = 770;
            int xk = 1050;
            int yo = 300;
            for (int y = 200; y < 501; y += 150)
            {
                g.FillRectangle(sb, xs, y, 200, 100);
                g.FillPolygon(sb, new Point[]
                {
                new Point(x,y),new Point(x,y),
                new Point(xk,y), new Point(x,yo),
                new Point(x,y)
                });
                //xs = xs - 30;
                //x = x - 30;
                //xk = xk - 30;
                yo = yo + 150;
            }
            // левые линии линии
            int x1 = 400;
            int xs1 = 400;
            int xk1 = 320;
            int yo1 = 300;
            for (int y1 = 200; y1 < 501; y1 += 150)
            {
                g.FillRectangle(sb, xs1, y1, 200, 100);
                g.FillPolygon(sb, new Point[]
                {
                new Point(x1,y1),new Point(x1,y1),
                new Point(xk1,y1), new Point(x1,yo1),
                new Point(x1,y1)
                });
                xs1 = xs1 - 50;
                x1 = x1 - 50;
                xk1 = xk1 - 50;
                yo1 = yo1 + 150;
            }
            g.DrawString("         ВС        МК", new Font("Arial", 64, FontStyle.Bold), Brushes.Blue, 250, 120);
            g.DrawString("им. А.А. Евстигнеева", new Font("Arial", 24), Brushes.Gray, 450, 605);
            g.DrawLine(p1, 510, 600, 750, 50);
            g.DrawLine(p1, 750, 50, 750, 600);
            g.DrawLine(p1, 600, 400, 750, 400);
        }
    }
}
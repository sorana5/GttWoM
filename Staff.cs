using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalSpreLumeaMuzicii
{
    internal class Staff
    {
        public static void draw_staff(Graphics graphics, bool ending)
        {
            Pen black_pen = new Pen(Color.Black, 5);
            Point p1 = new Point(100, 60);
            Point p2 = new Point(100, 80);
            Point p3 = new Point(100, 100);
            Point p4 = new Point(100, 120);
            Point p5 = new Point(100, 140);

            graphics.DrawLine(black_pen, p1, p1 + new Size(1100, 0));
            graphics.DrawLine(black_pen, p2, p2 + new Size(1100, 0));
            graphics.DrawLine(black_pen, p3, p3 + new Size(1100, 0));
            graphics.DrawLine(black_pen, p4, p4 + new Size(1100, 0));
            graphics.DrawLine(black_pen, p5, p5 + new Size(1100, 0));

            if (ending)
            {
                graphics.DrawLine(black_pen, new Point(1190, 58), new Point(1190, 143));
                graphics.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));
            }

            Image treble_clef = Image.FromFile(@"extra\cheie.png");
            graphics.DrawImage(treble_clef, 75, 25, 90, 155);
        }
    }
}

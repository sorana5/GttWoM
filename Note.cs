using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PortalSpreLumeaMuzicii
{
    internal class Note
    {
        public int alteration;
        public int octave;

        public static void draw_note(Graphics graphics, Point point, Pen pen)
        {
            graphics.DrawEllipse(pen, point.X, point.Y, 30, 20);
            if (point.Y == 150)
                graphics.DrawLine(pen, point - new Size(10, -10), point + new Size(40, 10));
            if (point.Y == 30 || point.Y == 20 || point.Y == 10)
                graphics.DrawLine(pen, new Point(point.X, 30) - new Size(10, -10), new Point(point.X, 30) + new Size(40, 10));
            if (point.Y == 10)
                graphics.DrawLine(pen, point - new Size(10, -10), point + new Size(40, 10));

            Image flat = Image.FromFile(@"extra\bemol.png");
            Image sharp = Image.FromFile(@"extra\diez.png");
            Image natural = Image.FromFile(@"extra\becar.png");

            //if (alteration)
            //    g.DrawImage(sharp, current_note - 38, element - 8, 35, 35);
            //if (element % 10 == 2)
            //    g.DrawImage(flat, current_note - 40, element - 15, 35, 35);
            //if (element % 10 == 3)
            //    g.DrawImage(natural, current_note - 35, element - 8, 25, 35);

        }
    }
}

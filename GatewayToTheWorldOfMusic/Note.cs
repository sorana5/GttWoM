using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GatewayToTheWorldOfMusic
{
    public class Note
    {
        public int alteration;
        public int altitude;

        public Note(int alteration, int altitude)
        {
            this.altitude = altitude;
            this.alteration = alteration;
        }

        public static void draw_note(Graphics graphics, Point point, Pen pen)
        {
            graphics.DrawEllipse(pen, point.X, point.Y, 30, 20);
            if (point.Y == 150)
                graphics.DrawLine(pen, point - new Size(10, -10), point + new Size(40, 10));
            if (point.Y == 30 || point.Y == 20 || point.Y == 10)
                graphics.DrawLine(pen, new Point(point.X, 30) - new Size(10, -10), new Point(point.X, 30) + new Size(40, 10));
            if (point.Y == 10)
                graphics.DrawLine(pen, point - new Size(10, -10), point + new Size(40, 10));

            Image flat, sharp, natural;
            if (pen.Color == Color.Black)
            {
                flat = Image.FromFile(@"extra\flat_black.png");
                sharp = Image.FromFile(@"extra\sharp_black.png");
                natural = Image.FromFile(@"extra\natural_black.png");
            }
            else
            {
                flat = Image.FromFile(@"extra\flat_purple.png");
                sharp = Image.FromFile(@"extra\sharp_purple.png");
                natural = Image.FromFile(@"extra\natural_purple.png");
            }

            //Image flat = Image.FromFile(@"extra\bemol.png");
            //Image sharp = Image.FromFile(@"extra\diez.png");
            //Image natural = Image.FromFile(@"extra\becar.png");

            //if (alteration)
            //    g.DrawImage(sharp, current_note - 38, element - 8, 35, 35);
            //if (element % 10 == 2)
            //    g.DrawImage(flat, current_note - 40, element - 15, 35, 35);
            //if (element % 10 == 3)
            //    g.DrawImage(natural, current_note - 35, element - 8, 25, 35);

        }

        public void draw_it(Graphics graphics, int location, Pen pen)
        {
            Point point = new Point(location, altitude);
            graphics.DrawEllipse(pen, point.X, point.Y, 30, 20);
            if (point.Y == 150)
                graphics.DrawLine(pen, point - new Size(10, -10), point + new Size(40, 10));
            if (point.Y == 30 || point.Y == 20 || point.Y == 10)
                graphics.DrawLine(pen, new Point(point.X, 30) - new Size(10, -10), new Point(point.X, 30) + new Size(40, 10));
            if (point.Y == 10)
                graphics.DrawLine(pen, point - new Size(10, -10), point + new Size(40, 10));

            Image flat, sharp, natural;
            if (pen.Color == Color.Black)
            {
                flat = Image.FromFile(@"extra\flat_black.png");
                sharp = Image.FromFile(@"extra\sharp_black.png");
                natural = Image.FromFile(@"extra\natural_black.png");
            }
            else
            {
                flat = Image.FromFile(@"extra\flat_purple.png");
                sharp = Image.FromFile(@"extra\sharp_purple.png");
                natural = Image.FromFile(@"extra\natural_purple.png");
            }


            if (alteration ==1)
                graphics.DrawImage(sharp, point.X - 38, point.Y - 8, 35, 35);
            if (alteration == -1)
                graphics.DrawImage(flat, point.X - 40, point.Y - 15, 35, 35);
            if (alteration == 10)
                graphics.DrawImage(natural, point.X - 35, point.Y - 8, 25, 35);
        }
    }
}

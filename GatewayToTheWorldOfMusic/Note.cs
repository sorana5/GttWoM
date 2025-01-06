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

        public static Dictionary<string, int> convert_notes = new Dictionary<string, int>()
        {
            ["do"] = 150,
            ["dod"] = 151,
            ["dob"] = 152,
            ["don"] = 153,
            ["re"] = 140,
            ["red"] = 141,
            ["reb"] = 142,
            ["ren"] = 143,
            ["mi"] = 130,
            ["mid"] = 131,
            ["mib"] = 132,
            ["min"] = 133,
            ["fa"] = 120,
            ["fad"] = 121,
            ["fab"] = 122,
            ["fan"] = 123,
            ["sol"] = 110,
            ["sold"] = 111,
            ["solb"] = 112,
            ["soln"] = 113,
            ["la"] = 100,
            ["lad"] = 101,
            ["lab"] = 102,
            ["lan"] = 103,
            ["si"] = 90,
            ["sid"] = 91,
            ["sib"] = 92,
            ["sin"] = 93,
            ["do2"] = 80,
            ["do2d"] = 81,
            ["do2b"] = 82,
            ["do2n"] = 83,
            ["re2"] = 70,
            ["re2d"] = 71,
            ["re2b"] = 72,
            ["re2n"] = 73,
            ["mi2"] = 60,
            ["mi2d"] = 61,
            ["mi2b"] = 62,
            ["mi2n"] = 63,
            ["fa2"] = 50,
            ["fa2d"] = 51,
            ["fa2b"] = 52,
            ["fa2n"] = 53,
            ["sol2"] = 40,
            ["sol2d"] = 41,
            ["sol2b"] = 42,
            ["sol2n"] = 43,
            ["la2"] = 30,
            ["la2d"] = 31,
            ["la2b"] = 32,
            ["la2n"] = 33,
            ["si2"] = 20,
            ["si2d"] = 21,
            ["si2b"] = 22,
            ["si2n"] = 23,
            ["do3"] = 10,
            ["do3d"] = 11,
            ["do3b"] = 12,
            ["do3n"] = 13
        };

        public int absolute_value(string scale)
        {
            int av = altitude;
            if (alteration != 10)
                av = altitude - alteration * 5;
            if (scale == "Sol Major" && (altitude == 120 || altitude == 50))
                av -= 5;
            if (scale == "Fa Major" && (altitude == 90 || altitude == 20))
                av += 5;
            return av;
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

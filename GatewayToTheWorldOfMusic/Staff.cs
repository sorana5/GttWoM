﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayToTheWorldOfMusic
{
    internal class Staff
    {
        public static void DrawStaff(Graphics graphics, bool ending)
        {
            Pen blackPen = new Pen(Color.Black, 5);
            Point p1 = new Point(100, 60);
            Point p2 = new Point(100, 80);
            Point p3 = new Point(100, 100);
            Point p4 = new Point(100, 120);
            Point p5 = new Point(100, 140);

            graphics.DrawLine(blackPen, p1, p1 + new Size(1100, 0));
            graphics.DrawLine(blackPen, p2, p2 + new Size(1100, 0));
            graphics.DrawLine(blackPen, p3, p3 + new Size(1100, 0));
            graphics.DrawLine(blackPen, p4, p4 + new Size(1100, 0));
            graphics.DrawLine(blackPen, p5, p5 + new Size(1100, 0));

            if (ending)
            {
                graphics.DrawLine(blackPen, new Point(1190, 58), new Point(1190, 143));
                graphics.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));
            }

            Image treble_clef = Image.FromFile(@"extra\cheie.png");
            graphics.DrawImage(treble_clef, 75, 25, 90, 155);
        }

        public static void DrawKeySignature(Graphics graphics, string scale)
        {
            Image flat = Image.FromFile(@"extra\flat_black.png");
            Image sharp = Image.FromFile(@"extra\sharp_black.png");
            Image natural = Image.FromFile(@"extra\natural_black.png");

            if (scale == "Sol Major")
                graphics.DrawImage(sharp, 140, 45, 33, 33);
            if (scale == "Fa Major")
                graphics.DrawImage(flat, 143, 78, 33, 33);
        }

        public static void DrawCurrentStaff(Graphics graphics, List<Note> currentStaff, Pen pen)
        {
            int location = 100;
            foreach (Note note in currentStaff)
            {
                location += 100;
                note.DrawIt(graphics, location, pen);
                if (location >= 1100)
                    return;
            }
        }
    }
}

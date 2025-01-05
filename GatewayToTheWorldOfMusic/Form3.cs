﻿//using PortalSpreLumeaMuzicii;
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

namespace GatewayToTheWorldOfMusic
{
    public partial class Piano : Form
    {
        public Piano()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("www.wikipedia.com");

            Staff.draw_staff(g, true);
            //List<Note> notes = new List<Note>();
            //draw_staff(sender, e);
        }

        Graphics g;
        //Staff staff = new Staff();
        Pen pen = new Pen(Color.MediumPurple, 5);

        Image treble_clef = Image.FromFile(@"extra\cheie.png");
        int location = 100;

        //private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    this.Text = e.Url.ToString() + "is loading...";

        //}

        public void Play(string notePath)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath);
            player.Play();
        }

        void press_note(object sender, EventArgs e, Note note)
        {
            location += 100;
            if (location <= 1100)
            {
                note.draw_it(g, location, pen);
                //Point point = new Point(location, note.altitude);
                //Note.draw_note(g, point, pen);
                //draw_note(sender, e, point, pen);
            }
        }

        //public static void draw_note(Graphics graphics, Point point, Pen pen)
        //{
        //    graphics.DrawEllipse(pen, point.X, point.Y, 30, 20);
        //    if (point.Y == 150)
        //        graphics.DrawLine(pen, point - new Size(10, -10), point + new Size(40, 10));
        //    if (point.Y == 30 || point.Y == 20 || point.Y == 10)
        //        graphics.DrawLine(pen, new Point(point.X, 30) - new Size(10, -10), new Point(point.X, 30) + new Size(40, 10));
        //    if (point.Y == 10)
        //        graphics.DrawLine(pen, point - new Size(10, -10), point + new Size(40, 10));

        //    Image flat = Image.FromFile(@"extra\bemol.png");
        //    Image sharp = Image.FromFile(@"extra\diez.png");
        //    Image natural = Image.FromFile(@"extra\becar.png");

        //    //if (alteration)
        //    //    g.DrawImage(sharp, current_note - 38, element - 8, 35, 35);
        //    //if (element % 10 == 2)
        //    //    g.DrawImage(flat, current_note - 40, element - 15, 35, 35);
        //    //if (element % 10 == 3)
        //    //    g.DrawImage(natural, current_note - 35, element - 8, 25, 35);

        //}

        //private void draw_note(object sender, EventArgs e, Point point, Pen p)
        //{
        //    g.DrawEllipse(p, point.X, point.Y, 30, 20);
        //    if (point.Y == 150)
        //        g.DrawLine(p, point - new Size(10, -10), point + new Size(40, 10));
        //    if (point.Y == 30 || point.Y == 20 || point.Y == 10)
        //        g.DrawLine(p, new Point(point.X, 30) - new Size(10, -10), new Point(point.X, 30) + new Size(40, 10));
        //    if (point.Y == 10)
        //        g.DrawLine(p, point - new Size(10, -10), point + new Size(40, 10));

        //}

        //private void draw_staff(object sender, EventArgs e)
        //{
        //    Pen p = new Pen(Color.Black, 5);
        //    Point p1 = new Point(100, 60);
        //    Point p2 = new Point(100, 80);
        //    Point p3 = new Point(100, 100);
        //    Point p4 = new Point(100, 120);
        //    Point p5 = new Point(100, 140);

        //    g.DrawLine(p, p1, p1 + new Size(1100, 0));
        //    g.DrawLine(p, p2, p2 + new Size(1100, 0));
        //    g.DrawLine(p, p3, p3 + new Size(1100, 0));
        //    g.DrawLine(p, p4, p4 + new Size(1100, 0));
        //    g.DrawLine(p, p5, p5 + new Size(1100, 0));

        //    g.DrawLine(p, new Point(1190, 58), new Point(1190, 143));
        //    g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));

        //    g.DrawImage(treble_clef, 75, 25, 90, 155);
        //}

        private void c4_Click(object sender, EventArgs e)
        {
            string fileName = "c4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 150));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fileName = "f4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 120));
        }

        private void csharp_Click(object sender, EventArgs e)
        {
            string fileName = "c4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 140));
            else
                press_note(sender, e, new Note(1, 150));
        }

        private void d4_Click(object sender, EventArgs e)
        {
            string fileName = "d4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 140));
        }

        private void d4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 130));
            else
                press_note(sender, e, new Note(1, 140));
        }

        private void e4_Click(object sender, EventArgs e)
        {
            string fileName = "e4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 130));
        }

        private void g4_Click(object sender, EventArgs e)
        {
            string fileName = "g4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 110));
        }

        private void g4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 100));
            else
                press_note(sender, e, new Note(1, 110));
        }

        private void a4_Click(object sender, EventArgs e)
        {
            string fileName = "a4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 100));
        }

        private void a4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 90));
            else
                press_note(sender, e, new Note(1, 100));
        }

        private void b4_Click(object sender, EventArgs e)
        {
            string fileName = "b4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 90));
        }

        private void c5_Click(object sender, EventArgs e)
        {
            string fileName = "c5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 80));
        }

        private void c5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "c5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 70));
            else
                press_note(sender, e, new Note(1, 80));
        }

        private void d5_Click(object sender, EventArgs e)
        {
            string fileName = "d5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 70));
        }

        private void d5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 60));
            else
                press_note(sender, e, new Note(1, 70));
        }

        private void e5_Click(object sender, EventArgs e)
        {
            string fileName = "e5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 60));
        }

        private void f5_Click(object sender, EventArgs e)
        {
            string fileName = "f5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 50));
        }

        private void g5_Click(object sender, EventArgs e)
        {
            string fileName = "g5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 40));
        }

        private void g5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 30));
            else
                press_note(sender, e, new Note(1, 40));
        }

        private void a5_Click(object sender, EventArgs e)
        {
            string fileName = "a5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 30));
        }

        private void a5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 20));
            else
                press_note(sender, e, new Note(1, 30));
        }

        private void b5_Click(object sender, EventArgs e)
        {
            string fileName = "b5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 20));
        }

        private void c6_Click(object sender, EventArgs e)
        {
            string fileName = "c6.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, new Note(0, 10));
        }

        private void f4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 110));
            else
                press_note(sender, e, new Note(1, 120));
        }

        private void f5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                press_note(sender, e, new Note(-1, 40));
            else
                press_note(sender, e, new Note(1, 50));
        }

        //public static void draw_staff(Graphics graphics, bool ending)
        //{
        //    Pen black_pen = new Pen(Color.Black, 5);
        //    Point p1 = new Point(100, 60);
        //    Point p2 = new Point(100, 80);
        //    Point p3 = new Point(100, 100);
        //    Point p4 = new Point(100, 120);
        //    Point p5 = new Point(100, 140);

        //    graphics.DrawLine(black_pen, p1, p1 + new Size(1100, 0));
        //    graphics.DrawLine(black_pen, p2, p2 + new Size(1100, 0));
        //    graphics.DrawLine(black_pen, p3, p3 + new Size(1100, 0));
        //    graphics.DrawLine(black_pen, p4, p4 + new Size(1100, 0));
        //    graphics.DrawLine(black_pen, p5, p5 + new Size(1100, 0));

        //    if (ending)
        //    {
        //        graphics.DrawLine(black_pen, new Point(1190, 58), new Point(1190, 143));
        //        graphics.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));
        //    }

        //    Image treble_clef = Image.FromFile(@"extra\cheie.png");
        //    graphics.DrawImage(treble_clef, 75, 25, 90, 155);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            location = 100;
            Staff.draw_staff(g, true);
        }

        private void sButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void switchButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

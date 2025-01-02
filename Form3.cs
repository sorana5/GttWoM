using PortalSpreLumeaMuzicii;
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
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("www.wikipedia.com");
            g = this.CreateGraphics();
            staff.draw_staff(g, true);
            //draw_staff(sender, e);
        }

        Graphics g;
        Staff staff = new Staff();
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

        void press_note(object sender, EventArgs e, int nota)
        {
            location += 100;
            if (location <= 1100)
            {
                Point point = new Point(location, nota);
                draw_note(sender, e, point, pen);
            }
        }

        private void draw_note(object sender, EventArgs e, Point point, Pen p)
        {
            g.DrawEllipse(p, point.X, point.Y, 30, 20);
            if (point.Y == 150)
                g.DrawLine(p, point - new Size(10, -10), point + new Size(40, 10));
            if (point.Y == 30 || point.Y == 20 || point.Y == 10)
                g.DrawLine(p, new Point(point.X, 30) - new Size(10, -10), new Point(point.X, 30) + new Size(40, 10));
            if (point.Y == 10)
                g.DrawLine(p, point - new Size(10, -10), point + new Size(40, 10));

        }

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
            press_note(sender, e, 150);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fileName = "f4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 120);
        }
        
        private void csharp_Click(object sender, EventArgs e)
        {
            string fileName = "c4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void d4_Click(object sender, EventArgs e)
        {
            string fileName = "d4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 140);
        }

        private void d4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void e4_Click(object sender, EventArgs e)
        {
            string fileName = "e4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 130);
        }

        private void g4_Click(object sender, EventArgs e)
        {
            string fileName = "g4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 110);
        }

        private void g4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void a4_Click(object sender, EventArgs e)
        {
            string fileName = "a4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 100);
        }

        private void a4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            string fileName = "b4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 90);
        }

        private void c5_Click(object sender, EventArgs e)
        {
            string fileName = "c5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 80);
        }

        private void c5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "c5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void d5_Click(object sender, EventArgs e)
        {
            string fileName = "d5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 70);
        }

        private void d5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void e5_Click(object sender, EventArgs e)
        {
            string fileName = "e5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 60);
        }

        private void f5_Click(object sender, EventArgs e)
        {
            string fileName = "f5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 50);
        }

        private void g5_Click(object sender, EventArgs e)
        {
            string fileName = "g5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 40);
        }

        private void g5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void a5_Click(object sender, EventArgs e)
        {
            string fileName = "a5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 30);
        }

        private void a5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            string fileName = "b5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 20);
        }

        private void c6_Click(object sender, EventArgs e)
        {
            string fileName = "c6.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 10);
        }

        private void f4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void f5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            location = 100;
            staff.draw_staff(g, true);
        }
    }
}

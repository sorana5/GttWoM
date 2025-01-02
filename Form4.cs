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
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
            string message = "Try to play the randomly generated notes, and afterwards you can check.";
            string title = "Try it yourself!";
            MessageBox.Show(message, title);
        }

        string notes = "";
        Graphics g;
        Staff staff = new Staff();
        Random random = new Random();
        List <int> generated = new List<int>();
        List <int> sung = new List<int>();
        int nr;

        public void Play(string notePath)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath); 
            player.Play();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("www.wikipedia.com");
            
            g = this.CreateGraphics();
            staff.draw_staff(g, true);
            //Pen p = new Pen(Color.Black, 5);
            //Point p1 = new Point(100, 60);
            //Point p2 = new Point(100, 80);
            //Point p3 = new Point(100, 100);
            //Point p4 = new Point(100, 120);
            //Point p5 = new Point(100, 140);

            //g.DrawLine(p, p1, p1 + new Size(1100, 0));
            //g.DrawLine(p, p2, p2 + new Size(1100, 0));
            //g.DrawLine(p, p3, p3 + new Size(1100, 0));
            //g.DrawLine(p, p4, p4 + new Size(1100, 0));
            //g.DrawLine(p, p5, p5 + new Size(1100, 0));

            //g.DrawLine(p, new Point(1190, 58), new Point(1190, 143));
            //g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));

            //Image treble_clef = Image.FromFile(@"extra\cheie.png");
            //g.DrawImage(treble_clef, 75, 25, 90, 155);

            //Point[] points = new Point[] { p1, p2, p3, p4, p5 };
            //g.DrawLine(p, p1, p1 + new Size(100, 0));
            //g.DrawLines(p, points);
        }

        //private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    this.Text = e.Url.ToString() + "is loading...";
            
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            string fileName = "f4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(120);
        }

        private void c4_Click(object sender, EventArgs e)
        {
            string fileName = "c4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(150);
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
            sung.Add(140);
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
            sung.Add(130);
        }

        private void g4_Click(object sender, EventArgs e)
        {
            string fileName = "g4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(110);
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
            sung.Add(100);
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
            sung.Add(90);
        }

        private void c5_Click(object sender, EventArgs e)
        {
            string fileName = "c5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(80);
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
            sung.Add(70);
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
            sung.Add(60);
        }

        private void f5_Click(object sender, EventArgs e)
        {
            string fileName = "f5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(50);
        }

        private void g5_Click(object sender, EventArgs e)
        {
            string fileName = "g5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(40);
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
            sung.Add(30);
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
            sung.Add(20);
        }

        private void c6_Click(object sender, EventArgs e)
        {
            string fileName = "c6.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(10);
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
            sung.Clear();
            staff.draw_staff(g, true);
            Pen p = new Pen(Color.Black, 5);
            //locatie = 100;
            //Pen p = new Pen(Color.Black, 5);
            //Point p1 = new Point(100, 60);
            //Point p2 = new Point(100, 80);
            //Point p3 = new Point(100, 100);
            //Point p4 = new Point(100, 120);
            //Point p5 = new Point(100, 140);
            ////Point[] points = new Point[] { p1, p2, p3, p4, p5 };
            ////g.DrawLine(p, p1, p1 + new Size(100, 0));
            ////g.DrawLines(p, points);
            //g.DrawLine(p, p1, p1 + new Size(1100, 0));
            //g.DrawLine(p, p2, p2 + new Size(1100, 0));
            //g.DrawLine(p, p3, p3 + new Size(1100, 0));
            //g.DrawLine(p, p4, p4 + new Size(1100, 0));
            //g.DrawLine(p, p5, p5 + new Size(1100, 0));

            //g.DrawLine(p, new Point(1190, 58), new Point(1190, 143));
            //g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));

            //Image treble_clef = Image.FromFile(@"extra\cheie.png");
            //g.DrawImage(treble_clef, 75, 25, 90, 155);

            /*Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 6);
            g.FillEllipse(brush, 100, 110, 15, 15);
            g.DrawArc(pen, 108, 103, 22, 22, 180, 200);
            g.DrawArc(pen, 90, 100, 40, 40, 180, -190);
            g.DrawLine(pen, 89, 123, 125, 50);
            g.DrawArc(pen, 108, 45, 15, 15, 180, 180);
            g.DrawLine(pen, 109, 45, 120, 162);
            g.DrawArc(pen, 101, 150, 18, 18, 180, -180);
            g.FillEllipse(brush, 96, 150, 10, 10);*/


            //pictureBox1.Visible = true;

            for (int i = 1; i <= 10; i++)
            {
                int nr = random.Next(10, 151);
                while (nr % 10 != 0)
                    nr = random.Next(10, 151);
                generated.Add(nr);
            }

            int note = 100;
            //Pen p = new Pen(Color.Black, 5);
            foreach (int elem in generated)
            {
                note += 100;
                if (note <= 1100)
                {
                    Point point = new Point(note, elem);
                    draw_note(sender, e, point, p);
                }
            }

        }

        private void draw_note(object sender, EventArgs e, Point point, Pen p)
        {
            g.DrawEllipse(p, point.X, point.Y, 30, 20);
            if (point.Y == 150)
                g.DrawLine(p, point - new Size (10, -10), point + new Size(40, 10));
            if (point.Y == 30 || point.Y == 20 || point.Y == 10)
                g.DrawLine(p, new Point(point.X, 30) - new Size(10, -10), new Point(point.X, 30) + new Size(40, 10));
            if (point.Y == 10)
                g.DrawLine(p, point - new Size(10, -10), point + new Size(40, 10));

        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            int note_number = 100;
            Pen p = new Pen(Color.Black, 5);
            foreach (int element in generated)
            {
                note_number += 100;
                if (note_number <= 1100)
                {
                    Point point = new Point(note_number, element);
                    draw_note(sender, e, point, p);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.MediumPurple, 5);
            int x = 100;
            foreach (int nota in sung)
            {
                x += 100;
                if (x <= 1100)
                {
                    Point point = new Point(x, nota);
                    draw_note(sender, e, point, p);
                }
            }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Melody melody = new Melody();
            melody.ShowDialog();
            melody = null;
            this.Show();
        }
    }
}

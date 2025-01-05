//using PortalSpreLumeaMuzicii;
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
            //Staff.draw_staff(g, true);
            //Image flat = Image.FromFile(@"extra\flat_black.png");
            //g.DrawImage(flat, 1400, 100, 30, 30);
            //Image sharp = Image.FromFile(@"extra\sharp_black.png");
            //g.DrawImage(sharp, 1300, 100, 30, 30);
        }

        //string notes = "";
        Graphics g;
        //Staff staff = new Staff();
        Random random = new Random();
        List <Note> generated = new List<Note>();
        List <Note> sung = new List<Note>();
        int total_score = 0;


        public void Play(string notePath)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath); 
            player.Play();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("www.wikipedia.com");
            
            g = this.CreateGraphics();
            Staff.draw_staff(g, true);
            score.Text = "You scored " + total_score + " so far.";
            Image flat = Image.FromFile(@"extra\flat_black.png");
            g.DrawImage(flat, 1385, 105, 30, 30);
            Image sharp = Image.FromFile(@"extra\sharp_black.png");
            g.DrawImage(sharp, 1300, 105, 30, 30);
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
            sung.Add(new Note(0, 120));
        }

        private void c4_Click(object sender, EventArgs e)
        {
            string fileName = "c4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 150));
        }

        private void csharp_Click(object sender, EventArgs e)
        {
            string fileName = "c4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 140));
            else
                sung.Add(new Note(1, 150));
        }

        private void d4_Click(object sender, EventArgs e)
        {
            string fileName = "d4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 140));
        }

        private void d4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 130));
            else
                sung.Add(new Note(1, 140));
        }

        private void e4_Click(object sender, EventArgs e)
        {
            string fileName = "e4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 130));
        }

        private void g4_Click(object sender, EventArgs e)
        {
            string fileName = "g4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 110));
        }

        private void g4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 100));
            else
                sung.Add(new Note(1, 110));
        }

        private void a4_Click(object sender, EventArgs e)
        {
            string fileName = "a4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 100));
        }

        private void a4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 90));
            else
                sung.Add(new Note(1, 100));
        }

        private void b4_Click(object sender, EventArgs e)
        {
            string fileName = "b4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 90));
        }

        private void c5_Click(object sender, EventArgs e)
        {
            string fileName = "c5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 80));
        }

        private void c5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "c5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 70));
            else
                sung.Add(new Note(1, 80));
        }

        private void d5_Click(object sender, EventArgs e)
        {
            string fileName = "d5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 70));
        }

        private void d5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 60));
            else
                sung.Add(new Note(1, 70));
        }

        private void e5_Click(object sender, EventArgs e)
        {
            string fileName = "e5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 60));
        }

        private void f5_Click(object sender, EventArgs e)
        {
            string fileName = "f5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 50));
        }

        private void g5_Click(object sender, EventArgs e)
        {
            string fileName = "g5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 40));
        }

        private void g5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 30));
            else
                sung.Add(new Note(1, 40));
        }

        private void a5_Click(object sender, EventArgs e)
        {
            string fileName = "a5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 30));
        }

        private void a5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 20));
            else
                sung.Add(new Note(1, 30));
        }

        private void b5_Click(object sender, EventArgs e)
        {
            string fileName = "b5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 20));
        }

        private void c6_Click(object sender, EventArgs e)
        {
            string fileName = "c6.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            sung.Add(new Note(0, 10));
        }

        private void f4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 110));
            else
                sung.Add(new Note(1, 120));
        }

        private void f5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                sung.Add(new Note(-1, 40));
            else
                sung.Add(new Note(1, 50));

        }

        private bool correctly_generated(Note note)
        {
            if (note.alteration == 1)
            {
                if (note.altitude == 130 || note.altitude == 90 || note.altitude == 60 || note.altitude == 20 || note.altitude == 10)
                    return false;
                return true;
            }
            if (note.alteration == -1)
            {
                if (note.altitude == 150 || note.altitude == 120 || note.altitude == 80 || note.altitude == 50 || note.altitude == 10)
                    return false;
                return true;
            }
            return true;
        }
        public int calculate_score(List<Note> sung, List<Note> song)
        {
            int score = 0;
            int i = 0;
            foreach (Note note in sung)
            {
                if (note.altitude == song[i].altitude && note.alteration == song[i].alteration)
                    score += 10;
                //int absolute_value_sung = note.altitude;
                //if (note.alteration != 10)
                //    absolute_value_sung = note.altitude - note.alteration * 10;

                //int absolute_expected_value = song[i].altitude;
                //if (song[i].alteration != 10)
                //    absolute_expected_value = song[i].altitude - song[i].alteration * 10;

                //if (absolute_value_sung == absolute_expected_value)
                //    score += 10;
                i++;
            }
            return score;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            sung.Clear();
            generated.Clear();
            total_score = 0;
            score.Text = "You scored " + total_score + " so far.";
            Staff.draw_staff(g, true);
            Pen black_pen = new Pen(Color.Black, 5);
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
                int altitude = random.Next(10, 151);
                while (altitude % 10 != 0)
                    altitude = random.Next(10, 151);
                int alteration = random.Next(-1, 2);
                while (correctly_generated(new Note(alteration, altitude)) == false)
                {
                    alteration = random.Next(-1, 2);
                }
                generated.Add(new Note(alteration, altitude));
                //generated.Add(nr);
            }

            Staff.draw_current_staff(g, generated, black_pen);

            //int location = 100;
            ////Pen p = new Pen(Color.Black, 5);
            //foreach (Note elem in generated)
            //{
            //    location += 100;
            //    if (location <= 1100)
            //    {
            //        elem.draw_it(g, location, black_pen);
            //        //Point point = new Point(location, elem);
            //        //Note.draw_note(g, point, black_pen);
            //        //draw_note(sender, e, point, black_pen);
            //    }
            //}

        }

        //private void draw_note(object sender, EventArgs e, Point point, Pen p)
        //{
        //    g.DrawEllipse(p, point.X, point.Y, 30, 20);
        //    if (point.Y == 150)
        //        g.DrawLine(p, point - new Size (10, -10), point + new Size(40, 10));
        //    if (point.Y == 30 || point.Y == 20 || point.Y == 10)
        //        g.DrawLine(p, new Point(point.X, 30) - new Size(10, -10), new Point(point.X, 30) + new Size(40, 10));
        //    if (point.Y == 10)
        //        g.DrawLine(p, point - new Size(10, -10), point + new Size(40, 10));

        //}

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }*/

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    int note_number = 100;
        //    Pen black_pen = new Pen(Color.Black, 5);
        //    foreach (int element in generated)
        //    {
        //        note_number += 100;
        //        if (note_number <= 1100)
        //        {
        //            Point point = new Point(note_number, element);
        //            Note.draw_note(g, point, black_pen);
        //            //draw_note(sender, e, point, p);
        //        }
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            Pen purple_pen = new Pen(Color.MediumPurple, 5);
            Staff.draw_current_staff(g, sung, purple_pen);
            total_score = calculate_score(sung, generated);
            score.Text = "You scored " + total_score + " so far.";
            //int location = 100;
            //foreach (Note note in sung)
            //{
            //    location += 100;
            //    if (location <= 1100)
            //    {
            //        note.draw_it(g, location, purple_pen);
            //        //Point point = new Point(location, note);
            //        //Note.draw_note(g, point, purple_pen);
            //        //draw_note(sender, e, point, p);
            //    }
            //}
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

﻿using System;
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
    public partial class Melody : Form
    {
        public Melody()
        {
            InitializeComponent();
            string message = "Try to figure out the song.";
            string title = "Have fun!";
            MessageBox.Show(message, title);
        }

        string note = "";
        Graphics g;
        Random random = new Random();

        Image treble_clef = Image.FromFile(@"extra\cheie.png");
        Image flat = Image.FromFile(@"extra\bemol.png");
        Image sharp = Image.FromFile(@"extra\diez.png");
        //Image diezc = Image.FromFile(@"extra\diezc.png");
        Image natural = Image.FromFile(@"extra\becar.png");

        public static List<Song> songs = new List<Song>();
        List < List < int > > song = new List<List<int>>();

        /*List<int> cantec = new List<int> { 80, 110, 110, 80, 100, 100, 100,
        90, 80, 70, 90, 80, 60, 80,
        80, 110, 110, 80, 100, 100, 100, 
        90, 80, 70, 90, 80, 60, 80,
        90, 80, 70, 70, 60, 80, 70, 70, 
        90, 80, 70, 70, 60, 80, 70, 70,
        80, 90, 100, 50, 60, 70, 60, 70, 80,
        80, 90, 100, 50, 60, 70, 40, 90, 80};*/
        //List<int> cantate = new List<int>();

        Pen purple_pen = new Pen(Color.MediumPurple, 5);
        int nr, staff_number = 0, location = 100, element = 0, number_staffs, song_number;

        /*private Dictionary<int, int> nrNote = new Dictionary<int, int>()
        {
            [-1] = 0, [0] = 0,
            [1] = 7, [2] = 7, [3] = 7, [4] = 7,
            [5] = 8, [6] = 8,
            [7] = 9, [8] = 9, [9] = 9
        };*/



        public void Play(string notePath) 
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath);
            player.Play();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Pen black_pen = new Pen(Color.Black, 5);
            Point p1 = new Point(100, 60);
            Point p2 = new Point(100, 80);
            Point p3 = new Point(100, 100);
            Point p4 = new Point(100, 120);
            Point p5 = new Point(100, 140);
            Point[] points = new Point[] { p1, p2, p3, p4, p5 };
            //g.DrawLine(p, p1, p1 + new Size(100, 0));
            //g.DrawLines(p, points);
            g.DrawLine(black_pen, p1, p1 + new Size(1100, 0));
            g.DrawLine(black_pen, p2, p2 + new Size(1100, 0));
            g.DrawLine(black_pen, p3, p3 + new Size(1100, 0));
            g.DrawLine(black_pen, p4, p4 + new Size(1100, 0));
            g.DrawLine(black_pen, p5, p5 + new Size(1100, 0));

            g.DrawLine(black_pen, new Point(1190, 58), new Point(1190, 143));
            g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));
                
            //Image cheiasol = Image.FromFile(@"extra\cheie.png");
            //Image becar = Image.FromFile(@"extra\becar.png");
            g.DrawImage(treble_clef, 75, 25, 90, 155);
            //g.DrawImage(becar, 125, 50, 90, 155);
            //Image diez = Image.FromFile(@"extra\diez.png");
            //Image bemol = Image.FromFile(@"extra\bemol.png");


            song_number = random.Next(0, Start.number_of_songs);
            song = songs[song_number]._note;
            label1.Text = "You just played " + songs[song_number]._title + "!";
            number_staffs = songs[song_number]._number_of_staffs;
            
            /*int nota = 100;
            //foreach (List<int> portativ in cantec)
            //{
                foreach (int elem in cantec[0])
                {
                    label1.Visible = true;
                nota++;
                    label1.Text = label1.Text + ' ' + Convert.ToString(elem) + ' ' + Convert.ToString(nota) + '\n';
                }
                label1.Text = label1.Text + '\n';
            //}*/
        }

        //private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    this.Text = e.Url.ToString() + "is loading...";

        //}

        void press_note(object sender, EventArgs e, int nota)
        {
            location += 100;
            if (staff_number <= number_staffs && location <= (song[staff_number-1].Count()+1) * 100)
            {
                Point point = new Point(location, nota);
                draw_note(sender, e, point, purple_pen);
            }
        }
        //if (nrPortativ <= 8 && locatie <= (nrNote[nrPortativ-1]+1) * 100
        private void button6_Click(object sender, EventArgs e)
        {
            string fileName = "f4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 120);
        }

        private void c4_Click(object sender, EventArgs e)
        {
            string fileName = "c4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 150);
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
            press_note(sender, e, 90);
            //g.DrawImage(diezc, locatie - 38, 100 - 8, 35, 35);
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
            //apasare_nota(sender, e, 30);
            //g.DrawImage(diezc, locatie - 38, 30 - 8, 35, 35);
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
            press_note(sender, e, 50);
            //g.DrawImage(diez, locatie - 38, 50 - 8, 35, 35);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            location = 100;
            element = 0;
            staff_number = 0;
            Pen black_pen = new Pen(Color.Black, 5);
            Point p1 = new Point(100, 60);
            Point p2 = new Point(100, 80);
            Point p3 = new Point(100, 100);
            Point p4 = new Point(100, 120);
            Point p5 = new Point(100, 140);
            //Point[] points = new Point[] { p1, p2, p3, p4, p5 };
            //g.DrawLine(p, p1, p1 + new Size(100, 0));
            //g.DrawLines(p, points);
            g.DrawLine(black_pen, p1, p1 + new Size(1100, 0));
            g.DrawLine(black_pen, p2, p2 + new Size(1100, 0));
            g.DrawLine(black_pen, p3, p3 + new Size(1100, 0));
            g.DrawLine(black_pen, p4, p4 + new Size(1100, 0));
            g.DrawLine(black_pen, p5, p5 + new Size(1100, 0));

            button3.Visible = true;
            label1.Visible = false;


            //g.DrawLine(p, new Point(1190, 58), new Point(1190, 143));
            //g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));

            //Image newImage = Image.FromFile(@"extra\cheie.png");
            //Image bemol = Image.FromFile(@"extra\bemol.png");
            //Image diez = Image.FromFile(@"extra\diez.png");
            //Image becar = Image.FromFile(@"extra\becar.png");

            g.DrawImage(treble_clef, 75, 25, 90, 155);
            if (songs[song_number]._scale == "Sol Major")
                g.DrawImage(sharp, 140, 45, 33, 33);
            if (songs[song_number]._scale == "Fa Major")
                g.DrawImage(flat, 143, 78, 33, 33);

            int current_note = 100;
            //Pen p = new Pen(Color.Black, 5);
            /*foreach (List <int> portativ in cantec)
            {
                foreach (int elem in portativ)
                {
                    label1.Visible = true;
                    label1.Text = label1.Text + Convert.ToString(elem);
                }

            }*/
            
            foreach (int element in song[0])
            {
                current_note += 100;
                Point point = new Point(current_note, element / 10 * 10);
                if (element % 10 == 1)
                    g.DrawImage(sharp, current_note - 38, element - 8, 35, 35);
                if (element % 10 == 2)
                    g.DrawImage(flat, current_note - 40, element - 15, 35, 35);
                if (element % 10 == 3)
                    g.DrawImage(natural, current_note - 35, element - 8, 25, 35);
                draw_note(sender, e, point, black_pen);
            }
            //label1.Visible = true;
            //label1.Text = label1.Text + Convert.ToString(element);
            /*for (int i = 0; i < nrNote[nrPortativ]; i++)
            {
                nota += 100;
                ///Point point = new Point(nota, cantec[element]);
                ///draw_note(sender, e, point, p);
                element++;
            }*/
            staff_number++;

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
            /*int nr = 100;
            Pen p = new Pen(Color.Black, 5);
            foreach (int elem in generate)
            {
                nr += 100;
                if (nr <= 1100)

                {
                    Point point = new Point(nr, elem);
                    draw_note(sender, e, point, p);
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            Pen black_pen = new Pen(Color.Black, 5);
            Point p1 = new Point(100, 60);
            Point p2 = new Point(100, 80);
            Point p3 = new Point(100, 100);
            Point p4 = new Point(100, 120);
            Point p5 = new Point(100, 140);
            Point[] points = new Point[] { p1, p2, p3, p4, p5 };
            //g.DrawLine(p, p1, p1 + new Size(100, 0));
            //g.DrawLines(p, points);
            g.DrawLine(black_pen, p1, p1 + new Size(1100, 0));
            g.DrawLine(black_pen, p2, p2 + new Size(1100, 0));
            g.DrawLine(black_pen, p3, p3 + new Size(1100, 0));
            g.DrawLine(black_pen, p4, p4 + new Size(1100, 0));
            g.DrawLine(black_pen, p5, p5 + new Size(1100, 0));

            //Image newImage = Image.FromFile(@"extra\cheie.png");
            //Image bemol = Image.FromFile(@"extra\bemol.png");
            //Image diez = Image.FromFile(@"extra\diez.png");
            //Image becar = Image.FromFile(@"extra\becar.png");
            g.DrawImage(treble_clef, 75, 25, 90, 155);
            if (songs[song_number]._scale == "Sol Major")
                g.DrawImage(sharp, 140, 45, 33, 33);
            if (songs[song_number]._scale == "Fa Major")
                g.DrawImage(flat, 143, 78, 33, 33);

            int nota = 100;
            //label1.Text = Convert.ToString(nrPortative);

            //Pen p = new Pen(Color.Black, 5);
            if (staff_number < number_staffs)
            {
                foreach (int element in song[staff_number])
                {
                    nota += 100;
                    Point point = new Point(nota, element / 10 * 10);
                    if (element % 10 == 1)
                        g.DrawImage(sharp, nota - 38, element - 8, 35, 35);
                    if (element % 10 == 2)
                        g.DrawImage(flat, nota - 40, element - 15, 35, 35);
                    if (element % 10 == 3)
                        g.DrawImage(natural, nota - 35, element - 8, 25, 35);
                    draw_note(sender, e, point, black_pen);
                }
                staff_number++;
                location = 100;
                if (staff_number == number_staffs)
                {
                    g.DrawLine(black_pen, new Point(1190, 58), new Point(1190, 143));
                    g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));
                    button3.Visible = false;
                    label1.Visible = true;
                }
                //g.DrawLine(p, new Point(1150, 58), new Point(1150, 143));
                /*for (int i = 0; i < nrNote[nrPortativ]; i++)
                {   
                    nota += 100;
                    ///Point point = new Point(nota, cantec[element]);
                    ///draw_note(sender, e, point, p);
                    element++;
                }*/
            }
            /*else
            {
                for (int i = 0; i < nrNote[nrPortativ]; i++)
                {
                    nota += 100;
                    ///Point point = new Point(nota, cantec[element]);
                    ///draw_note(sender, e, point, p);
                    element++;
                }
                locatie = 100;
                g.DrawLine(p, new Point(1190, 58), new Point(1190, 143));
                g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));
                button3.Visible = false;
                label1.Visible = true;
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*g.Clear(BackColor);
            Pen p = new Pen(Color.Black, 5);
            Point p1 = new Point(100, 60);
            Point p2 = new Point(100, 80);
            Point p3 = new Point(100, 100);
            Point p4 = new Point(100, 120);
            Point p5 = new Point(100, 140);
            Point[] points = new Point[] { p1, p2, p3, p4, p5 };
            //g.DrawLine(p, p1, p1 + new Size(100, 0));
            //g.DrawLines(p, points);
            g.DrawLine(p, p1, p1 + new Size(1100, 0));
            g.DrawLine(p, p2, p2 + new Size(1100, 0));
            g.DrawLine(p, p3, p3 + new Size(1100, 0));
            g.DrawLine(p, p4, p4 + new Size(1100, 0));
            g.DrawLine(p, p5, p5 + new Size(1100, 0));

            Image newImage = Image.FromFile(@"extra\cheie.png");
            g.DrawImage(newImage, 75, 25, 90, 155);

            int nr = 100;
            //Pen p = new Pen(Color.Black, 5);
            if (nrPortativ < 6)
            {
                for (int elem = nrPortativ * 10; elem < nrPortativ * 10 + 10; elem++)
                {
                    nr += 100;
                    Point point = new Point(nr, generate[elem]);
                    draw_note(sender, e, point, p);
                }
                nrPortativ++;
                locatie = 100;
            }
            else
            {
                for (int elem = nrPortativ * 10; elem < generate.Count(); elem++)
                {
                    nr += 100;
                    Point point = new Point(nr, generate[elem]);
                    draw_note(sender, e, point, p);
                }
                g.DrawLine(p, new Point(1190, 58), new Point(1190, 143));
                g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));
            }*/
        }

        void urmator(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            Pen black_pen = new Pen(Color.Black, 5);
            Point p1 = new Point(100, 60);
            Point p2 = new Point(100, 80);
            Point p3 = new Point(100, 100);
            Point p4 = new Point(100, 120);
            Point p5 = new Point(100, 140);
            Point[] points = new Point[] { p1, p2, p3, p4, p5 };
            //g.DrawLine(p, p1, p1 + new Size(100, 0));
            //g.DrawLines(p, points);
            g.DrawLine(black_pen, p1, p1 + new Size(1100, 0));
            g.DrawLine(black_pen, p2, p2 + new Size(1100, 0));
            g.DrawLine(black_pen, p3, p3 + new Size(1100, 0));
            g.DrawLine(black_pen, p4, p4 + new Size(1100, 0));
            g.DrawLine(black_pen, p5, p5 + new Size(1100, 0));

            Image newImage = Image.FromFile(@"extra\cheie.png");
            g.DrawImage(newImage, 75, 25, 90, 155);

            int nr = 100;
            //Pen p = new Pen(Color.Black, 5);
            if (staff_number < 6)
            {
                for (int elem = staff_number * 10; elem < staff_number * 10 + 10; elem++)
                {
                    nr += 100;
                    ///Point point = new Point(nr, cantec[elem]);
                    ///draw_note(sender, e, point, p);
                }
                staff_number++;
                location = 100;
            }
            else
            {
                for (int elem = staff_number * 10; elem < song.Count(); elem++)
                {
                    nr += 100;
                    ///Point point = new Point(nr, cantec[elem]);
                    ///draw_note(sender, e, point, p);
                }
                g.DrawLine(black_pen, new Point(1190, 58), new Point(1190, 143));
                g.DrawLine(new Pen(Color.Black, 10), new Point(1200, 58), new Point(1200, 143));
            }
        }
    }
}

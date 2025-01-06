//using PortalSpreLumeaMuzicii;
using GatewayToTheWorldOfMusic.Data;
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
using static System.Formats.Asn1.AsnWriter;

namespace GatewayToTheWorldOfMusic
{
    public partial class Melody : Form
    {
        Graphics g;
        Random random = new Random();
        public static List<Song> songs = new List<Song>();
        List<List<Note>> song = new List<List<Note>>();
        List<Note> sung = new List<Note>();
        int total_score = 0, staff_number = 0, location = 100, number_staffs, song_number;
        public Melody()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            string message = "Try to figure out the song.";
            string title = "Have fun!";
            MessageBox.Show(message, title);
        }

        public void Play(string notePath) 
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath);
            player.Play();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Staff.draw_staff(g, false);
            sung.Clear();
            song_number = random.Next(0, Start.number_of_songs);
            song = songs[song_number].notes;
            label1.Text = "You just played " + songs[song_number].title + "!";
            current_score.Text = "Your current score is " + total_score + ".";
            number_staffs = songs[song_number].number_of_staffs;
        }

        void press_note(object sender, EventArgs e, int alteration, int altitude)
        {
            location += 100;
            Pen purple_pen = new Pen(Color.MediumPurple, 5);
            if (staff_number <= number_staffs && staff_number > 0 && location <= (song[staff_number-1].Count()+1) * 100)
            {
                Note note = new Note(alteration, altitude);
                sung.Add(note);

                int absolute_value_sung = altitude - alteration * 5;

                int index = location / 100 - 2;
                int absolute_expected_value = song[staff_number - 1][index].absolute_value(songs[song_number].scale);
                // verifies if the sung note is correct
                if (absolute_value_sung == absolute_expected_value)
                {
                    total_score += 10;
                    song[staff_number - 1][index].draw_it(g, location, purple_pen);
                }
                else
                {
                    note.draw_it(g, location, purple_pen);
                }
                current_score.Text = "Your current score is " + total_score + ".";
                // update highscore
                if (total_score > Authentification.current_student.Highscore)
                {
                    Authentification.current_student.Highscore = total_score;
                    using (var context = new AppDbContext())
                    {
                        context.Students.Update(Authentification.current_student);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fileName = "f4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 120);
        }

        private void c4_Click(object sender, EventArgs e)
        {
            string fileName = "c4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 150);
        }

        private void csharp_Click(object sender, EventArgs e)
        {
            string fileName = "c4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 150);
        }

        private void d4_Click(object sender, EventArgs e)
        {
            string fileName = "d4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 140);
        }

        private void d4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 140);
        }

        private void e4_Click(object sender, EventArgs e)
        {
            string fileName = "e4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 130);
        }

        private void g4_Click(object sender, EventArgs e)
        {
            string fileName = "g4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 110);
        }

        private void g4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 110);
        }

        private void a4_Click(object sender, EventArgs e)
        {
            string fileName = "a4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 100);
        }

        private void a4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 100);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            string fileName = "b4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 90);
        }

        private void c5_Click(object sender, EventArgs e)
        {
            string fileName = "c5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 80);
        }

        private void c5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "c5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 80);
        }

        private void d5_Click(object sender, EventArgs e)
        {
            string fileName = "d5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 70);
        }

        private void d5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 70);
        }

        private void e5_Click(object sender, EventArgs e)
        {
            string fileName = "e5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 60);
        }

        private void f5_Click(object sender, EventArgs e)
        {
            string fileName = "f5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 50);
        }

        private void g5_Click(object sender, EventArgs e)
        {
            string fileName = "g5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 40);
        }

        private void g5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 40);
        }

        private void a5_Click(object sender, EventArgs e)
        {
            string fileName = "a5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 30);
        }

        private void a5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 30);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            string fileName = "b5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 20);
        }

        private void c6_Click(object sender, EventArgs e)
        {
            string fileName = "c6.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 0, 10);
        }

        private void f4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 120);
        }

        private void f5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            press_note(sender, e, 1, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reset everything
            g.Clear(BackColor);
            this.location = 100;
            staff_number = 0;
            total_score = 0;
            current_score.Text = "Your current score is " + total_score + ".";
            sung.Clear();
            Staff.draw_staff(g, false);
            Pen black_pen = new Pen(Color.Black, 5);

            button3.Visible = true;
            label1.Visible = false;

            Staff.draw_key_signature(g, songs[song_number].scale);
            Staff.draw_current_staff(g, song[0], black_pen);
            staff_number++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
     
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // draws the next staff
            g.Clear(BackColor);
            Staff.draw_staff(g, false);
            Pen black_pen = new Pen(Color.Black, 5);
            Staff.draw_key_signature(g, songs[song_number].scale);

            current_score.Text = "Your current score is " + total_score + ".";
            if (staff_number < number_staffs)
            {
                Staff.draw_current_staff(g, song[staff_number], black_pen);
                staff_number++;
                this.location = 100;
                sung.Clear();
                if (staff_number == number_staffs)
                {
                    Staff.draw_staff(g, true);
                    button3.Visible = false;
                    label1.Visible = true;
                }
            }
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
           
        }
    }
}

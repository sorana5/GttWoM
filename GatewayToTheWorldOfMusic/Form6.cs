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
        int totalScore = 0, staffNumber = 0, location = 100, numberStaffs, songNumber;
        private Lesson currentLesson;
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
            Staff.DrawStaff(g, false);
            sung.Clear();
            songNumber = random.Next(0, Start.numberOfSongs);
            song = songs[songNumber].notes;
            label1.Text = "You just played " + songs[songNumber].title + "!";
            currentScore.Text = "Your current score is " + totalScore + ".";
            numberStaffs = songs[songNumber].numberOfStaffs;
        }

        void PressNote(object sender, EventArgs e, int alteration, int altitude)
        {
            location += 100;
            Pen purplePen = new Pen(Color.MediumPurple, 5);
            if (staffNumber <= numberStaffs && staffNumber > 0 && location <= (song[staffNumber-1].Count()+1) * 100)
            {
                Note note = new Note(alteration, altitude);
                sung.Add(note);

                int absoluteValueSung = altitude - alteration * 5;

                int index = location / 100 - 2;
                int absoluteExpectedValue = song[staffNumber - 1][index].AbsoluteValue(songs[songNumber].scale);
                // verifies if the sung note is correct
                if (absoluteValueSung == absoluteExpectedValue)
                {
                    totalScore += 10;
                    song[staffNumber - 1][index].DrawIt(g, location, purplePen);
                }
                else
                {
                    note.DrawIt(g, location, purplePen);
                }
                currentScore.Text = "Your current score is " + totalScore + ".";
                // update highscore
                //if (total_score > Authentification.current_student.Highscore)
                //{
                //    Authentification.current_student.Highscore = total_score;
                //    using (var context = new AppDbContext())
                //    {
                //        context.Students.Update(Authentification.current_student);
                //        context.SaveChanges();
                //    }
                //}

                using (var context = new AppDbContext())
                {
                    currentLesson.score = totalScore;
                    context.Lessons.Update(currentLesson);
                    context.SaveChanges();

                    if (totalScore > Authentification.currentStudent.Highscore)
                    {
                        Authentification.currentStudent.Highscore = totalScore;
                        context.Students.Update(Authentification.currentStudent);
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
            PressNote(sender, e, 0, 120);
        }

        private void c4_Click(object sender, EventArgs e)
        {
            string fileName = "c4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 150);
        }

        private void csharp_Click(object sender, EventArgs e)
        {
            string fileName = "c4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 150);
        }

        private void d4_Click(object sender, EventArgs e)
        {
            string fileName = "d4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 140);
        }

        private void d4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 140);
        }

        private void e4_Click(object sender, EventArgs e)
        {
            string fileName = "e4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 130);
        }

        private void g4_Click(object sender, EventArgs e)
        {
            string fileName = "g4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 110);
        }

        private void g4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 110);
        }

        private void a4_Click(object sender, EventArgs e)
        {
            string fileName = "a4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 100);
        }

        private void a4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 100);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            string fileName = "b4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 90);
        }

        private void c5_Click(object sender, EventArgs e)
        {
            string fileName = "c5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 80);
        }

        private void c5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "c5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 80);
        }

        private void d5_Click(object sender, EventArgs e)
        {
            string fileName = "d5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 70);
        }

        private void d5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 70);
        }

        private void e5_Click(object sender, EventArgs e)
        {
            string fileName = "e5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 60);
        }

        private void f5_Click(object sender, EventArgs e)
        {
            string fileName = "f5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 50);
        }

        private void g5_Click(object sender, EventArgs e)
        {
            string fileName = "g5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 40);
        }

        private void g5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 40);
        }

        private void a5_Click(object sender, EventArgs e)
        {
            string fileName = "a5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 30);
        }

        private void a5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 30);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            string fileName = "b5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 20);
        }

        private void c6_Click(object sender, EventArgs e)
        {
            string fileName = "c6.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 0, 10);
        }

        private void f4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 120);
        }

        private void f5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, 1, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reset everything
            g.Clear(BackColor);
            this.location = 100;
            staffNumber = 0;
            totalScore = 0;
            currentScore.Text = "Your current score is " + totalScore + ".";
            sung.Clear();
            Staff.DrawStaff(g, false);
            Pen blackPen = new Pen(Color.Black, 5);

            button3.Visible = true;
            label1.Visible = false;

            Staff.DrawKeySignature(g, songs[songNumber].scale);
            Staff.DrawCurrentStaff(g, song[0], blackPen);
            staffNumber++;

            using (var context = new AppDbContext())
            {
                var newLesson = new Lesson
                {
                    lessonID = Lesson.GenerateIndex() + 1,
                    lessonType = "singASong",
                    studentID = Authentification.currentStudent.Id,
                    date = DateTime.UtcNow,
                    score = 0
                };

                context.Lessons.Add(newLesson);
                context.SaveChanges();

                currentLesson = newLesson;
            }

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
            Staff.DrawStaff(g, false);
            Pen blackPen = new Pen(Color.Black, 5);
            Staff.DrawKeySignature(g, songs[songNumber].scale);

            currentScore.Text = "Your current score is " + totalScore + ".";
            if (staffNumber < numberStaffs)
            {
                Staff.DrawCurrentStaff(g, song[staffNumber], blackPen);
                staffNumber++;
                this.location = 100;
                sung.Clear();
                if (staffNumber == numberStaffs)
                {
                    Staff.DrawStaff(g, true);
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

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

namespace GatewayToTheWorldOfMusic
{
    public partial class Testing : Form
    {
        Graphics g;
        Random random = new Random();
        List<Note> generated = new List<Note>();
        List<Note> sung = new List<Note>();
        int total_score = 0;
        Lesson currentLesson;

        public Testing()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            string message = "Try to play the randomly generated notes, and afterwards you can check.";
            string title = "Try it yourself!";
            MessageBox.Show(message, title);
        }


        public void Play(string notePath)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath);
            player.Play();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Staff.draw_staff(g, true);
            score.Text = "You scored " + total_score + " so far.";
            Image flat = Image.FromFile(@"extra\flat_black.png");
            g.DrawImage(flat, 1350, 65, 30, 30);
            Image sharp = Image.FromFile(@"extra\sharp_black.png");
            g.DrawImage(sharp, 1257, 65, 31, 30);
        }

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
            if (note.alteration == 1)   // there can't be E4#, B4#, E5#, B5# or C6# 
            {
                if (note.altitude == 130 || note.altitude == 90 || note.altitude == 60 || note.altitude == 20 || note.altitude == 10)
                    return false;
                return true;
            }
            if (note.alteration == -1)  // there can't be C4b, F4b, C5b, F5b or C6b
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
                i++;
                if (i == 10)    // only the first 10 notes played count
                    break;
            }
            if (score == 100)
            {
                string message = "Congratulations! You got all the notes right!";
                string title = "Congratulations!";
                MessageBox.Show(message, title);
            }
            return score;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // resets everything
            g.Clear(BackColor);
            sung.Clear();
            generated.Clear();
            total_score = 0;
            score.Text = "You scored " + total_score + " so far.";
            Staff.draw_staff(g, true);
            Image flat = Image.FromFile(@"extra\flat_black.png");
            g.DrawImage(flat, 1350, 65, 30, 30);
            Image sharp = Image.FromFile(@"extra\sharp_black.png");
            g.DrawImage(sharp, 1257, 65, 31, 30);
            Pen black_pen = new Pen(Color.Black, 5);

            for (int i = 1; i <= 10; i++)   // generates 10 random notes
            {
                int altitude = random.Next(10, 151);
                while (altitude % 10 != 0)
                    altitude = random.Next(10, 151);
                int alteration = random.Next(-1, 2);
                while (correctly_generated(new Note(alteration, altitude)) == false)
                    alteration = random.Next(-1, 2);
                generated.Add(new Note(alteration, altitude));
            }

            Staff.draw_current_staff(g, generated, black_pen);

            using (var context = new AppDbContext())
            {
                //var current_student = context.Students.FirstOrDefault(s => s.Id == Authentification.current_student.Id);
                //if (current_student != null)
                //{
                //    current_student.Highscore = 0;
                //    context.Students.Update(current_student);
                //    context.SaveChanges();
                //}
                var newLesson = new Lesson
                {
                    lessonID = Lesson.generate_index() + 1,
                    lessonType = "randomlyGenerated",
                    studentID = Authentification.current_student.Id,
                    date = DateTime.UtcNow,
                    score = 0
                };

                context.Lessons.Add(newLesson);
                context.SaveChanges();

                currentLesson = newLesson;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // shows the progress
            Pen purple_pen = new Pen(Color.MediumPurple, 5);
            Staff.draw_current_staff(g, sung, purple_pen);
            total_score = calculate_score(sung, generated);
            score.Text = "You scored " + total_score + " so far.";

            using (var context = new AppDbContext())
            {
                currentLesson.score = total_score;
                context.Lessons.Update(currentLesson);
                context.SaveChanges();

                if (total_score > Authentification.current_student.Highscore)
                {
                    Authentification.current_student.Highscore = total_score;
                    context.Students.Update(Authentification.current_student);
                    context.SaveChanges();
                }
            }

            //if (total_score > Authentification.current_student.Highscore)
            //{
            //    Authentification.current_student.Highscore = total_score;
            //    using (var context = new AppDbContext())
            //    {
            //        context.Students.Update(Authentification.current_student);
            //        context.SaveChanges();
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

        private void score_Click(object sender, EventArgs e)
        {

        }
    }
}

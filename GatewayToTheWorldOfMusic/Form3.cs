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
    public partial class Piano : Form
    {
        Graphics g;
        int location = 100;
        public Piano()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Staff.DrawStaff(g, true);
            Image flat = Image.FromFile(@"extra\flat_black.png");
            g.DrawImage(flat, 1400, 97, 30, 30);
            Image sharp = Image.FromFile(@"extra\sharp_black.png");
            g.DrawImage(sharp, 1310, 97, 30, 30);
        }

        public void Play(string notePath)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath);
            player.Play();
        }

        void PressNote(object sender, EventArgs e, Note note)
        {
            // a note was pressed and has to appear on the staff
            Pen purplePen = new Pen(Color.MediumPurple, 5);
            location += 100;
            if (location <= 1100)
            {
                note.DrawIt(g, location, purplePen);
            }
        }

        private void c4_Click(object sender, EventArgs e)
        {
            string fileName = "c4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 150));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fileName = "f4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 120));
        }

        private void csharp_Click(object sender, EventArgs e)
        {
            string fileName = "c4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 140));
            else
                PressNote(sender, e, new Note(1, 150));
        }

        private void d4_Click(object sender, EventArgs e)
        {
            string fileName = "d4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 140));
        }

        private void d4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 130));
            else
                PressNote(sender, e, new Note(1, 140));
        }

        private void e4_Click(object sender, EventArgs e)
        {
            string fileName = "e4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 130));
        }

        private void g4_Click(object sender, EventArgs e)
        {
            string fileName = "g4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 110));
        }

        private void g4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 100));
            else
                PressNote(sender, e, new Note(1, 110));
        }

        private void a4_Click(object sender, EventArgs e)
        {
            string fileName = "a4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 100));
        }

        private void a4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 90));
            else
                PressNote(sender, e, new Note(1, 100));
        }

        private void b4_Click(object sender, EventArgs e)
        {
            string fileName = "b4.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 90));
        }

        private void c5_Click(object sender, EventArgs e)
        {
            string fileName = "c5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 80));
        }

        private void c5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "c5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 70));
            else
                PressNote(sender, e, new Note(1, 80));
        }

        private void d5_Click(object sender, EventArgs e)
        {
            string fileName = "d5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 70));
        }

        private void d5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "d5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 60));
            else
                PressNote(sender, e, new Note(1, 70));
        }

        private void e5_Click(object sender, EventArgs e)
        {
            string fileName = "e5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 60));
        }

        private void f5_Click(object sender, EventArgs e)
        {
            string fileName = "f5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 50));
        }

        private void g5_Click(object sender, EventArgs e)
        {
            string fileName = "g5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 40));
        }

        private void g5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "g5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 30));
            else
                PressNote(sender, e, new Note(1, 40));
        }

        private void a5_Click(object sender, EventArgs e)
        {
            string fileName = "a5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 30));
        }

        private void a5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "a5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 20));
            else
                PressNote(sender, e, new Note(1, 30));
        }

        private void b5_Click(object sender, EventArgs e)
        {
            string fileName = "b5.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 20));
        }

        private void c6_Click(object sender, EventArgs e)
        {
            string fileName = "c6.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            PressNote(sender, e, new Note(0, 10));
        }

        private void f4sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f4sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 110));
            else
                PressNote(sender, e, new Note(1, 120));
        }

        private void f5sharp_Click(object sender, EventArgs e)
        {
            string fileName = "f5sharp.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"note\", fileName);
            Play(path);
            if (switchButton.Checked)
                PressNote(sender, e, new Note(-1, 40));
            else
                PressNote(sender, e, new Note(1, 50));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // resets everything
            g.Clear(BackColor);
            location = 100;
            Staff.DrawStaff(g, true);
            Image flat = Image.FromFile(@"extra\flat_black.png");
            g.DrawImage(flat, 1400, 97, 30, 30);
            Image sharp = Image.FromFile(@"extra\sharp_black.png");
            g.DrawImage(sharp, 1310, 97, 30, 30);
        }

        private void sButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void switchButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

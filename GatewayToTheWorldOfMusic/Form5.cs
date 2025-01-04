using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatewayToTheWorldOfMusic
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
            slidePic.ImageLocation = string.Format(@"poze\1.png");
            label1.Text = Texts[1];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private int imageNumber = 1;
        private Dictionary<int, string> Texts = new Dictionary<int, string>()
        {
            [1] = "The staff comprises five lines and four spaces, numbered from the bottom to the top.",
            [2] = "Clefs assign individual notes to certain lines or spaces.\nThe most used ones are the Treble (or G) and Bass (or F) clefs.",
            [3] = "The Treble Clef wraps around the second staff line, and any note placed on this line becomes Sol (or G).",
            [4] = "Therefore, the note on the space above Sol is La (A), the note on the line above La is Si (B) and so on.",
            [5] = "There is a corresponding letter for each note, from A to G, the first one being La.\n A ledger line is a small line that extends the staff when there is no more room for the notes.",
            [6] = "The clefs indicate the place of the note on the staff. This is how The F Clef shows where is Fa on the staff, and after that the rest of the staff can be filled.",
            [7] = "Usually, the piano sheet music contains two pairs of staffs, where the G clef corresponds to the right hand, and the F clef corresponds to the left hand. It can be observed that the position of the note C is the same.",
            [8] = "On the piano, each note on the staff corresponds to a key.",
            [9] = "A semitone (or a half step) represents the distance between two adjacent keys on the piano.\nFor example, there is a semitone between the keys numbered 1 and 2, or 2 and 3.",
            [10] = "A tone (or a whole step) is made up of 2 semitones, for example, between keys 1 and 3 is a tone.\nThus, it can be seen that between most notes there are tones, except between mi-fa and si-do.",
            [11] = "In order to access the note between do and re, the black key that is a semitone from both do and re, accidentals are used. Thus, do sharp will represent that note, since the sharp raises any note by a semitone.",
            [12] = "At the same time, re flat has the same value as do sharp, since the flat lowers any note by a semitone.",
            [13] = "The accidentals are, in order: double flat, which lowers the note by a tone; flat, which lowers the note by a semitone; natural, which returns the note to its natural form; sharp, which raises the note by a semitone; and double sharp, which raises the note by a tone.",
            [14] = "For example, to obtain do double sharp, we raise the note by a tone (2 semitones), or 2 keys, reaching the note re.",
            [15] = "This is the C Major scale. Any major scale has semitones between the III-IV and VII-VIII degrees, and tones between the other degrees. The illustrated scale is called C Major because it satisfies this condition of intervals and starts on the note C.",
            [16] = "To build the D Major scale, one must start from the note D, and if the semitone intervals of a major scale cannot be followed, accidentals are added.",
            [17] = "As a result, major scales can be built from any note if the mentioned condition is met. So, what is this scale called?",
            [18] = "A Major! To avoid putting these sharps in front of every note F, C, or G, they are added at the beginning of each staff, after the clef, forming the key signature.",
            [19] = "The same thing happens with flats, which can even be added to the starting note. The scale in the image?",
            [20] = "D flat Major! These accidentals cannot be placed randomly, but only in the order of their appearance. Thus, the order of sharps is F-C-G-D-A-E-B, and the flats are B-E-A-D-G-C-F."
        };

        private void LoadNextImage()
        {
            slidePic.ImageLocation = string.Format(@"poze\{0}.png", imageNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageNumber < 20)
            {
                imageNumber++;
                label1.Text = Texts[imageNumber];
                button2.Visible = true;
            }
            if (imageNumber == 20)
                button1.Visible = false;
            LoadNextImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageNumber > 1)
            {
                imageNumber--;
                label1.Text = Texts[imageNumber];
                button1.Visible = true;
            }
            if (imageNumber == 1)
                button2.Visible = false;
            LoadNextImage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

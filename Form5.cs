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

namespace PortalSpreLumeaMuzicii
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            slidePic.ImageLocation = string.Format(@"poze\1.png");
            label1.Text = Texte[1];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private int imageNumber = 1;
        private Dictionary<int, string> Texte = new Dictionary<int, string>()
        {
            [1] = "Portativul este format din 5 linii și 4 spații, numerotate de jos în sus.",
            [2] = "Cheile alocă fiecărei note un loc pe portativ, fie pe o linie, fie pe un spațiu.\nCele mai folosite sunt cheia Sol și cheia Fa.",
            [3] = "Cheia Sol atribuie oricărei note plasate pe a doua linie a portativului valoarea Sol (G).",
            [4] = "Astfel, nota de deasupra notei Sol va fi La (A), după Si (B) și așa mai departe.",
            [5] = "Fiecărei note îi corespunde o literă de la A la G, iar notația începe de pe La.\nLiniile ajutătoare extind portativul atunci când nu mai este spațiu pentru note.",
            [6] = "Cheile arată locul notei pe portativ. De aceea, cheia Fa marchează locul notei Fa, iar după se pot completa restul notelor.",
            [7] = "De obicei, partitura pentru pian conține câte 2 perechi de portative, unde cheia Sol corespunde mâinii drepte, iar cheia Fa mâinii stângi. Se poate observa că locul notei Do este același.",
            [8] = "La pian, fiecărei note de pe portativ îi corespunde o clapă.",
            [9] = "Un semiton reprezintă distanța dintre două clape alăturate de pe pian.\nSpre exemplu, există semiton între clapele numerotate cu 1 și 2, sau 2 și 3.",
            [10] = "Un ton este format din 2 semitonuri, spre exemplu între clapele 1 și 3 este un ton. \nAstfel, se observă cum între majoritatea notelor sunt tonuri, mai puțin între mi-fa și si-do",
            [11] = "do diez",
            [12] = "re bemol",
            [13] = "alteratii",
            [14] = "do dublu diez",
            [15] = "gama do major",
            [16] = "se incepe de pe alta nota",
            [17] = "la major",
            [18] = "se pun alteratii",
            [19] = "re major",
            [20] = "re major din nou"
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
                label1.Text = Texte[imageNumber];
            }
            LoadNextImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageNumber > 1)
            {
                imageNumber--;
                label1.Text = Texte[imageNumber];
            }
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

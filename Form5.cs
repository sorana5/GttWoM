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
            [11] = "Pentru a se putea accesa nota dintre do și re, clapa neagră aflată la un semiton de do și unul de re, se folosesc alterații. Astfel, do diez va reprezenta nota respectivă, întrucât diezul urcă orice notă cu un semiton.",
            [12] = "În același timp, re bemol are aceeași valoare cu do diez, din moment ce bemolul coboară orice notă cu un semiton.",
            [13] = "Alterațiile sunt, în ordine: dublu bemol, care coboară nota cu un ton, bemol - coboară nota cu un semiton, becar - aduce nota la forma naturală, diez - urcă cu un semiton și dublu diez - urcă cu un ton.",
            [14] = "Spre exemplu, pentru a obține do dublu diez, urcăm nota cu un ton (2 semitonuri), sau 2 clape, ajungând chiar la nota re.",
            [15] = "Aceasta este gama Do Major. Orice gamă majoră are semitonuri între treptele III-IV și VII-VIII, iar în rest tonuri. Gama ilustrată se numește Do Major întrucât îndeplinește această condiție a intervalelor și începe de pe nota do.",
            [16] = "Pentru a construi gama Re Major, trebuie să se înceapă de pe nota re, iar dacă nu pot fi respectate semitonurile specifice unei game majore, se adaugă alterații.",
            [17] = "În consecință, se pot construi game majore de pe orice notă, dacă este îndeplinită condiția menționată. Oare cum se numește gama aceasta?",
            [18] = "La Major! Pentru a nu se pune acești diezi în fața fiecărei note fa, do sau sol, se adaugă la începutul fiecărui portativ, după cheie, formând armura.",
            [19] = "Același lucru se întâmplă și cu bemolii, care se pot adăuga chiar și la nota de început. Gama din imagine?",
            [20] = "Re bemol Major! Aceste alterații nu se pot pune oricum, ci doar în ordinea apariției lor. Astfel, ordinea diezilor este fa-do-sol-re-la-mi-si, iar bemolii si-mi-la-re-sol-do-fa."
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

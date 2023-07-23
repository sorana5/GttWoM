using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalSpreLumeaMuzicii
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        public static int nrCantece;

        private Dictionary<string, int> convertireNote = new Dictionary<string, int>()
        {
            ["do"] = 150,
            ["dod"] = 151,
            ["dob"] = 152,
            ["don"] = 153,
            ["re"] = 140,
            ["red"] = 141,
            ["reb"] = 142,
            ["ren"] = 143,
            ["mi"] = 130,
            ["mid"] = 131,
            ["mib"] = 132,
            ["min"] = 133,
            ["fa"] = 120,
            ["fad"] = 121,
            ["fab"] = 122,
            ["fan"] = 123,
            ["sol"] = 110,
            ["sold"] = 111,
            ["solb"] = 112,
            ["soln"] = 113,
            ["la"] = 100,
            ["lad"] = 101,
            ["lab"] = 102,
            ["lan"] = 103,
            ["si"] = 90,
            ["sid"] = 91,
            ["sib"] = 92,
            ["sin"] = 93,
            ["do2"] = 80,
            ["do2d"] = 81,
            ["do2b"] = 82,
            ["do2n"] = 83,
            ["re2"] = 70,
            ["re2d"] = 71,
            ["re2b"] = 72,
            ["re2n"] = 73,
            ["mi2"] = 60,
            ["mi2d"] = 61,
            ["mi2b"] = 62,
            ["mi2n"] = 63,
            ["fa2"] = 50,
            ["fa2d"] = 51,
            ["fa2b"] = 52,
            ["fa2n"] = 53,
            ["sol2"] = 40,
            ["sol2d"] = 41,
            ["sol2b"] = 42,
            ["sol2n"] = 43,
            ["la2"] = 30,
            ["la2d"] = 31,
            ["la2b"] = 32,
            ["la2n"] = 33,
            ["si2"] = 20,
            ["si2d"] = 21,
            ["si2b"] = 22,
            ["si2n"] = 23,
            ["do3"] = 10,
            ["do3d"] = 11,
            ["do3b"] = 12,
            ["do3n"] = 13
        };

        public void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"Cantece.txt");
            nrCantece = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < nrCantece; i++)
            {
                string nume = sr.ReadLine();
                string gama = sr.ReadLine();
                string valori = sr.ReadLine();
                List<List<int>> note = new List<List<int>>();
                int linie = 0;
                while (valori[0] != '.')
                {
                    string[] denumireNote = valori.Split(' ');
                    List <int> portativ = new List<int>();
                    foreach (var denumire in denumireNote)
                        portativ.Add(convertireNote[denumire]);
                    note.Add(portativ);
                    linie++;
                    valori = sr.ReadLine();
                }
                Form6.cantece.Add(new Cantec(nume, gama, linie, note));
            }
            /*foreach (List<int> portativ in Form6.cantece[0]._note)
            {
                foreach (int elem in portativ)
                {
                    //label1.Visible = true;
                    titlu.Text = titlu.Text + ' ' + Convert.ToString(elem);
                }
                titlu.Text = titlu.Text + '\n';
            }*/
            /*while (!sr.EndOfStream)
            {
                string nume = sr.ReadLine();
                //titlu.Text = nume;
                string valori = sr.ReadLine();
                string[] bits = valori.Split(' ');
                //int nota = sr.Read();
                List <int> note = new List <int>();
                foreach (var bit in bits)
                    note.Add(convertireNote[bit]);
                Form6.cantece.Add(new Cantec(nume, note));
                //foreach (var notes in note)
                    //titlu.Text = titlu.Text + Convert.ToString(notes);
            }*/
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cuprins cuprins = new Cuprins();
            cuprins.ShowDialog();
            cuprins = null;
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show(); 
        }

        private void titlu_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        private Dictionary<string, int> convertireNote = new Dictionary<string, int>()
        {
            ["do"] = 150,
            ["re"] = 140,
            ["mi"] = 130,
            ["fa"] = 120,
            ["sol"] = 110,
            ["la"] = 100,
            ["lad"] = 101,
            ["lan"] = 103,
            ["si"] = 90,
            ["sib"] = 92,
            ["do2"] = 80,
            ["re2"] = 70,
            ["mi2"] = 60,
            ["fa2"] = 50,
            ["sol2"] = 40,
            ["la2"] = 30,
            ["si2"] = 20,
            ["do3"] = 10
        };

        public void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"Cantece.txt");
            int nrCantece = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < nrCantece; i++)
            {
                string nume = sr.ReadLine();
                string gama = sr.ReadLine();
                //titlu.Text = nume;
                string valori = sr.ReadLine();
                List<List<int>> note = new List<List<int>>();
                int linie = 0;
                while (valori[0] != '.')
                {
                    string[] bits = valori.Split(' ');
                    List <int> portativ = new List<int>();
                    foreach (var bit in bits)
                        portativ.Add(convertireNote[bit]);
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

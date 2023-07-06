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

namespace PortalSpreLumeaMuzicii
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"Cantece.txt");
            while (!sr.EndOfStream)
            {
                string nume = sr.ReadLine();
                //titlu.Text = nume;
                string valori = sr.ReadLine();
                string[] bits = valori.Split(' ');
                int nota = sr.Read();
                List <int> note = new List <int>();
                foreach (var bit in bits)
                    note.Add(int.Parse(bit));
                Form6.cantece.Add(new Cantec(nume, note));
                //foreach (var notes in note)
                    //titlu.Text = titlu.Text + Convert.ToString(notes);
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuprins cuprins = new Cuprins();
            cuprins.Show();
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

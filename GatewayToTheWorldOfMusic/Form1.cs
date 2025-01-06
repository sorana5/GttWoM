using GatewayToTheWorldOfMusic.Data;
using GatewayToTheWorldOfMusic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

namespace GatewayToTheWorldOfMusic
{
    public partial class Start : Form
    {
        private readonly AppDbContext _context;
        public Start()
        {
            InitializeComponent();
            _context = Program.ServiceProvider.GetRequiredService<AppDbContext>();
        }

        public static int number_of_songs;

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    //Some Code
        //    services.AddDbContext<AppDbContext>();
        //    //Some Code
        //}

        private void LoadStudents()
        {
            var students = _context.Students.ToList();
            // Display the students on your form, etc.
            MessageBox.Show($"Number of students: {students.Count}");
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            // reads the songs from the file
            StreamReader sr = new StreamReader(@"Cantece.txt");
            number_of_songs = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < number_of_songs; i++)
            {
                string title = sr.ReadLine();
                string scale = sr.ReadLine();
                string values = sr.ReadLine();
                List<List<Note>> notes = new List<List<Note>>();
                int line = 0;
                while (values[0] != '.')
                {
                    string[] notes_names = values.Split(' ');
                    List <Note> current_staff = new List<Note>();
                    foreach (var name in notes_names)
                    {
                        int converted_note = Note.convert_notes[name];
                        if (converted_note % 10 == 1)
                            current_staff.Add(new Note(1, converted_note / 10 * 10));
                        else if (converted_note % 10 == 2)
                            current_staff.Add(new Note(-1, converted_note / 10 * 10));
                        else if (converted_note % 10 == 3)
                            current_staff.Add(new Note(10, converted_note / 10 * 10));
                        else
                            current_staff.Add(new Note(0, converted_note / 10 * 10));
                    }
                        //current_staff.Add(new Note(0, convert_notes[name]));
                    notes.Add(current_staff);
                    line++;
                    values = sr.ReadLine();
                }
                Melody.songs.Add(new Song(title, scale, line, notes));
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
            //this.Hide();
            //Cuprins cuprins = new Cuprins();
            //cuprins.ShowDialog();
            //cuprins = null;
            //this.Show();

            this.Hide();
            Authentification authentification = new Authentification();
            authentification.ShowDialog();
            authentification = null;
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Testing frm = new Testing();
            frm.Show(); 
        }

        private void titlu_Click(object sender, EventArgs e)
        {

        }
    }
}

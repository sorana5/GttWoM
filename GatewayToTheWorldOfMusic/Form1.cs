﻿using GatewayToTheWorldOfMusic.Data;
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
        public static int numberOfSongs;
        public Start()
        {
            InitializeComponent();
            _context = Program.ServiceProvider.GetRequiredService<AppDbContext>();
        }


        //private void LoadStudents()
        //{
        //    var students = _context.Students.ToList();
        //    // Display the students on your form, etc.
        //    MessageBox.Show($"Number of students: {students.Count}");
        //}


        public void Form1_Load(object sender, EventArgs e)
        {
            // reads the songs from the file
            StreamReader sr = new StreamReader(@"Cantece.txt");
            numberOfSongs = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < numberOfSongs; i++)
            {
                string title = sr.ReadLine();
                string scale = sr.ReadLine();
                string values = sr.ReadLine();
                List<List<Note>> notes = new List<List<Note>>();
                int line = 0;
                while (values[0] != '.')
                {
                    string[] notesNames = values.Split(' ');
                    // creates the current staff (a list of nodes), which will be added to the list of staffs
                    List<Note> currentStaff = new List<Note>();
                    foreach (var name in notesNames)
                    {
                        int convertedNote = Note.ConvertNotes[name];
                        if (convertedNote % 10 == 1)   // is sharp
                            currentStaff.Add(new Note(1, convertedNote / 10 * 10));
                        else if (convertedNote % 10 == 2)  // is flat
                            currentStaff.Add(new Note(-1, convertedNote / 10 * 10));
                        else if (convertedNote % 10 == 3)  // is natural
                            currentStaff.Add(new Note(10, convertedNote / 10 * 10));
                        else   // no accident
                            currentStaff.Add(new Note(0, convertedNote / 10 * 10));
                    }
                    notes.Add(currentStaff);
                    line++;
                    values = sr.ReadLine();
                }
                Melody.songs.Add(new Song(title, scale, line, notes));
            }
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

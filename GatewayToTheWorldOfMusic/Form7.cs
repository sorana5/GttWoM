using GatewayToTheWorldOfMusic.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatewayToTheWorldOfMusic
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           // index = 0;
        }

        public static Student current_student = null;
        public static Teacher current_teacher = null;

        private void register_Click(object sender, EventArgs e)
        {
           
            using (var context = new AppDbContext())
            {
                if (switchButton.Checked)
                {
                    if (context.Teachers.Any(s => s.Username == username.Text))
                    {
                        MessageBox.Show("Username already exists!");
                        return;
                    }
                    var newTeacher = new Teacher
                    {
                        Id = Teacher.generate_index() + 1,
                        Username = username.Text,
                        Password = password.Text,
                        Name = name.Text
                    };

                    context.Teachers.Add(newTeacher);
                    current_teacher = newTeacher;
                }
                else
                {
                    if (context.Students.Any(s => s.Username == username.Text))
                    {
                        MessageBox.Show("Username already exists!");
                        return;
                    }
                    var newStudent = new Student
                    {
                        Id = Student.generate_index() + 1,
                        Username = username.Text,
                        Password = password.Text,
                        Name = name.Text,
                        Highscore = 0
                    };

                    context.Students.Add(newStudent);
                    current_student = newStudent;
                }


                context.SaveChanges();
                MessageBox.Show("Account created successfully!");
                username.Clear();
                password.Clear();
                name.Clear();

                this.Hide();
                Cuprins cuprins = new Cuprins();
                cuprins.ShowDialog();
                cuprins = null;
                this.Show();
            }
        }
    }
}

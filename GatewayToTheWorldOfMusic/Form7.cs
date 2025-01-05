using GatewayToTheWorldOfMusic.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            password.UseSystemPasswordChar = true;
        }

        public static Student current_student = null;
        public static Teacher current_teacher = null;

        private static string encrypt(string password, string key)
        {
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = Encoding.UTF8.GetBytes(key);
                myAes.IV = new byte[16];

                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(password);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }

                //byte[] encrypted = EncryptStringToBytes_Aes(password, myAes.Key, myAes.IV);
                //return Encoding.Default.GetString(encrypted);
            }
        }

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
                        Password = encrypt(password.Text, "SecretEncryptKey"),
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
                        Password = encrypt(password.Text, "SecretEncryptKey"),
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

        private void logIn_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (switchButton.Checked)
                {
                    var teacher = context.Teachers.FirstOrDefault(s => s.Username == username.Text && s.Password == password.Text);
                    if (teacher == null)
                    {
                        MessageBox.Show("Invalid username or password!");
                        return;
                    }
                    current_teacher = teacher;
                }
                else
                {
                    var student = context.Students.FirstOrDefault(s => s.Username == username.Text && s.Password == password.Text);
                    if (student == null)
                    {
                        MessageBox.Show("Invalid username or password!");
                        return;
                    }
                    current_student = student;
                }

                //context.SaveChanges();
                //MessageBox.Show("Account created successfully!");
                //username.Clear();
                //password.Clear();
                //name.Clear();

                this.Hide();
                Cuprins cuprins = new Cuprins();
                cuprins.ShowDialog();
                cuprins = null;
                this.Show();
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !showPassword.Checked;
        }
    }
}

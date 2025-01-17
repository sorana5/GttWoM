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
            password.UseSystemPasswordChar = true;
            label3.Text = "If you don't have an account yet, \nenter also your name and press Register.";
        }

        public static Student currentStudent = null;
        public static Teacher currentTeacher = null;

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
            }
        }

        private bool CheckLenght()
        {
            if (username.Text.Length < 3 || password.Text.Length < 3 || name.Text.Length < 3)
            {
                MessageBox.Show("Username, password and name must have at least 3 characters!");
                return false;
            }
            return true;
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
                    if (!CheckLenght())
                        return;
                    var newTeacher = new Teacher
                    {
                        Id = Teacher.GenerateIndex() + 1,
                        Username = username.Text,
                        Password = encrypt(password.Text, "SecretEncryptKey"),
                        Name = name.Text
                    };

                    context.Teachers.Add(newTeacher);
                    currentTeacher = newTeacher;

                    context.SaveChanges();
                    MessageBox.Show("Teacher account created successfully!");

                    this.Hide();
                    ManageClass manageClass = new ManageClass();
                    manageClass.ShowDialog();
                    manageClass = null;
                    this.Show();
                }
                else
                {
                    if (context.Students.Any(s => s.Username == username.Text))
                    {
                        MessageBox.Show("Username already exists!");
                        return;
                    }
                    if (!CheckLenght())
                        return;
                    var newStudent = new Student
                    {
                        Id = Student.GenerateIndex(),
                        Username = username.Text,
                        Password = encrypt(password.Text, "SecretEncryptKey"),
                        Name = name.Text,
                        Highscore = 0
                    };

                    context.Students.Add(newStudent);
                    currentStudent = newStudent;

                    context.SaveChanges();
                    MessageBox.Show("Student account created successfully!");

                    this.Hide();
                    Cuprins cuprins = new Cuprins();
                    cuprins.ShowDialog();
                    cuprins = null;
                    this.Show();
                }

                username.Clear();
                password.Clear();
                name.Clear();

            }
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (switchButton.Checked)
                {
                    var teacher = context.Teachers.FirstOrDefault(s => s.Username == username.Text && s.Password == encrypt(password.Text, "SecretEncryptKey"));
                    if (teacher == null)
                    {
                        MessageBox.Show("Invalid username or password!");
                        return;
                    }
                    currentTeacher = teacher;

                    this.Hide();
                    ManageClass manageClass = new ManageClass();
                    manageClass.ShowDialog();
                    manageClass = null;
                    this.Show();
                }
                else
                {
                    var student = context.Students.FirstOrDefault(s => s.Username == username.Text && s.Password == encrypt(password.Text, "SecretEncryptKey"));
                    if (student == null)
                    {
                        MessageBox.Show("Invalid username or password!");
                        return;
                    }
                    currentStudent = student;
                    
                    this.Hide();
                    Cuprins cuprins = new Cuprins();
                    cuprins.ShowDialog();
                    cuprins = null;
                    this.Show();
                }
                username.Clear();
                password.Clear();
                name.Clear();

            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !showPassword.Checked;
        }
    }
}

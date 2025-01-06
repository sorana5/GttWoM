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
    public partial class ManageClass : Form
    {
        public ManageClass()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            load_list();
            instruction.Text = "To delete a student, enter the username \nin the text box and press the delete button: ";
        }

        private void load_list()
        {
            listView1.Items.Clear();
            using (var context = new AppDbContext())
            {
                var students = context.Students.OrderByDescending(student => student.Highscore).ThenBy(student => student.Id).ToList();
                //var students = context.Students.OrderByDescending(highscore).ToList();
                foreach (var student in students)
                {
                    string[] newRow = { student.Id.ToString(), student.Username, student.Name, student.Highscore.ToString() };
                    ListViewItem item = new ListViewItem(newRow);
                    listView1.Items.Add(item);
                    //item.SubItems.Add(student.Id);
                    //item.SubItems.Add(student.Username);
                    //item.SubItems.Add(student.Name);
                    //item.SubItems.Add(student.Highscore.ToString());
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var students = context.Students.ToList();
                var toDelete = students.FirstOrDefault(student => student.Username == studentId.Text);
                if (toDelete == null)
                {
                    MessageBox.Show("Student not found");
                    return;
                }
                context.Students.Remove(toDelete);
                //var maxId = students.Max(s => s.Id);
                //GatewayToTheWorldOfMusic.ExecuteSqlRaw($"SELECT setval('students_id_seq', {maxId}, true)");
                //students.OrderBy(s => s.Id);
                //int newId = 1;
                //foreach (var student in students)
                //{
                //    student.Id = newId;
                //    context.Students.Update(student);
                //    newId++;
                //}
                //using (var context = new AppDbContext())
                //{
                //    context.Students.Update(Authentification.current_student);
                //    context.SaveChanges();
                //}
                context.SaveChanges();
            }
            load_list();
        }
    }
}

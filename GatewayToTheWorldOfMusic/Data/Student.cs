using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GatewayToTheWorldOfMusic.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Highscore { get; set; }

        //public static bool valid_username(string username)
        //{
        //    using (var context = new AppDbContext())
        //    {
        //        var students = context.Students.ToList();
        //        foreach (Student student in students)
        //        {
        //            if (student.Username == username)
        //                return false;
        //        }
        //        return true;
        //    }
        //}

        public static int generate_index()
        {
            using (var context = new AppDbContext())
            {
                var students = context.Students.ToList();
                return students.Count;
            }
        }
    }
}
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


        public static int GenerateIndex()
        {
            using (var context = new AppDbContext())
            {
                int index = 1;
                var students = context.Students.OrderBy(s => s.Id).ToList();
                foreach(Student student in students)
                {
                    if (student.Id != index)
                        return index;
                    index++;
                }
                return index;
            }
        }
    }
}
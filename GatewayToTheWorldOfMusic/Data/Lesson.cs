namespace GatewayToTheWorldOfMusic.Data
{
    public class Lesson
    {
        public int lessonID { get; set; }
        public string lessonType { get; set; }
        public int score { get; set; }
        public int studentID { get; set; }
        public DateTime date { get; set; }

        public static int generate_index()
        {
            using (var context = new AppDbContext())
            {
                var lessons = context.Lessons.ToList();
                return lessons.Count;
            }
        }
    }
}
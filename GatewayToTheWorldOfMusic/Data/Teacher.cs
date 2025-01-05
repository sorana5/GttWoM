namespace GatewayToTheWorldOfMusic.Data
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public static int generate_index()
        {
            using (var context = new AppDbContext())
            {
                var teachers = context.Teachers.ToList();
                return teachers.Count;
            }
        }
    }
}
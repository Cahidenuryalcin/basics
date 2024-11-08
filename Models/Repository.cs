namespace basics.Models
{
    public class Repository
    {

        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){

            new Course(){Id=1,Title="aspnet kursu", Description="guzel bir kurs", Image="1.jpg"},
            new Course(){Id=2,Title="pyhton kursu", Description="iyi bir kurs", Image="2.jpg"},
            new Course(){Id=3,Title="django kursu", Description=" harika bir kurs", Image="3.jpg"},
             new Course(){Id=4,Title="javascript kursu", Description=" harika bir kurs", Image="1.jpg"},
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }
    }

}
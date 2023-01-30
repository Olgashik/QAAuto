namespace Employees
{
    internal class DegreeTeacher: Teacher
    {
        public string DegreecSience { get;  }
        
        public string TitleTeacher { get; }

        public DegreeTeacher(Person person, int taxID, string[] course,string degreecSience, string titleTeacher)
            : base (person, taxID, course)
        {
            DegreecSience = degreecSience;
            TitleTeacher = titleTeacher;
        }
    }
}

namespace Employees
{
    internal class DegreeTeacher: Teacher
    {
        public string DegreecSience { get;  }
        
        public string TitleTeacher { get; }

        public DegreeTeacher(Person person, int taxId, string[] course,string degreecSience, string titleTeacher)
            : base (person, taxId, course)
        {
            DegreecSience = degreecSience;
            TitleTeacher = titleTeacher;
        }
    }
}

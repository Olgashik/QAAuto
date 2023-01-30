namespace Employees
{
    internal class Teacher: UniversityEmployee
    {
        public string[] Courses { get; set; }

        public Teacher(Person person, int taxID, string[] courses)
            : base(person, taxID)
        {
            Courses = courses;
        }

        public override string GetOfficialDuties()
        {
            return string.Format("{0} {1} {2}", base.GetOfficialDuties(), "Teacher", string.Join(" ", Courses));
        }
    }
}

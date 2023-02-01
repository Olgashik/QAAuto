namespace QAACommon.Models
{
    internal class Teacher: UniversityEmployee
    {
        public string[] Courses { get; set; }

        public Teacher(Person person, int taxId, string[] courses)
            : base(person, taxId)
        {
            Courses = courses;
        }

        public override string GetOfficialDuties()
        {
            return string.Format("{0} {1} {2}", base.GetOfficialDuties(), "Teacher", string.Join(" ", Courses));
        }
    }
}

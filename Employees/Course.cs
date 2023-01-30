namespace Employees
{
    internal class Course
    {
        public string NameCourse { get; }
        public string DescriptionCourse { get; }

        public Course(string nameCourse, string descriptionCourse)
        {
            NameCourse = nameCourse;
            DescriptionCourse = descriptionCourse;
        }
    }
}

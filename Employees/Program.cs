namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kolya = new Person("Kolya", "Kolyakin");
            var kolyaCourses = new  string[] { "Mathematics", "Physics" };
            var kolyaTeacher = new Teacher(kolya, 111, kolyaCourses);

            var petya = new Person("Petr", "Petrov");
            var petyaCourses = new string[] { "Mathematics"};
            var petyaTeacher = new Teacher(petya, 112, petyaCourses);
                        
            var vasya = new Person("Vasya", "Pupkin");
            var vasyaCourses = new string[] { "Literature" };
            var vasyaTeacher = new Teacher(vasya, 113, vasyaCourses);

            var tom = new Person("Tom", "Tomek");
            var tomSupportStaff = new SupportStaff(tom, 221, "Cleaner", "university building cleaning");

            var chrom = new Person("Chrom", "Chromuch");
            var chromSupportStaff = new SupportStaff(chrom, 222, "Security guard", "university building security");

            var universityEmployees = new UniversityEmployee[] { kolyaTeacher, petyaTeacher, vasyaTeacher, tomSupportStaff, chromSupportStaff };

            Console.WriteLine("-------------------");
            foreach (var employee in universityEmployees)
            {
                Console.WriteLine(employee.GetOfficialDuties());
            }
            Console.WriteLine("-------------------");
            foreach (var employee in universityEmployees)
            {
                if (employee is Teacher)
                {
                    Console.WriteLine(employee.GetOfficialDuties());
                }
            }


            Console.ReadLine();
        }
    }
}
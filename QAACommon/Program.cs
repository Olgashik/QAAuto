using QAACommon.Models;

namespace QAACommon
{
    internal class Program
    {
        const string SUBJECT = "Math";

        static void Main(string[] args)
        {
            /*
             Address vasyaAddress = new Address(11, 12, "vasyastreet", "vasyacity");
            Person vasyaPerson = new Person("vasya", "Pupkin", vasyaAddress);
            SubjectScore vasyaMath = new SubjectScore(9, "Math");
            SubjectScore vasyaPhysics = new SubjectScore(8, "Physics");
            SubjectScore[] vasyaSubjectScores = new SubjectScore[] { vasyaMath, vasyaPhysics };
            Candidate vasya = new Candidate(vasyaPerson, vasyaSubjectScores);

            Address kolyaAddress = new Address(21, 22, "kolyastreet", "kolyacity");
            Person kolyaPerson = new Person("Kolya", "Novik", kolyaAddress);
            SubjectScore kolyaMath = new SubjectScore(10, "Math");
            SubjectScore kolyaPhysics = new SubjectScore(9, "Physics");
            SubjectScore[] kolyaSubjectScore = new SubjectScore[] { kolyaMath, kolyaPhysics };
            Candidate kolya = new Candidate(kolyaPerson, kolyaSubjectScore);

            Address olyaAddress = new Address(31, 32, "olyastreet", "olyacity");
            Person olyaPerson = new Person("Olya", "Sorina", olyaAddress);
            SubjectScore olyaMath = new SubjectScore(7, "Math");
            SubjectScore olyaPhysics = new SubjectScore(9, "Physics");
            SubjectScore[] olyaSubjectScore = new SubjectScore[] { olyaMath, olyaPhysics };
            Candidate olya = new Candidate(olyaPerson, olyaSubjectScore);

            Address zuzyaAddress = new Address(41, 42, "zuzyastreet", "zuzyacity");
            Person zuzyaPerson = new Person("Zuzya", "Hurt", zuzyaAddress);
            SubjectScore zuzyaMath = new SubjectScore(8, "Math");
            SubjectScore zuzyaPhysics = new SubjectScore(5, "Physics");
            SubjectScore[] zuzyaSubjectScore = new SubjectScore[] { zuzyaMath, zuzyaPhysics };
            Candidate zuzya = new Candidate(zuzyaPerson, zuzyaSubjectScore);

            Address lewaAddress = new Address(51, 52, "lewastreet", "lewacity");
            Person lewaPerson = new Person("Lewa", "Bag", lewaAddress);
            SubjectScore lewaMath = new SubjectScore(3, "Math");
            SubjectScore lewaPhysics = new SubjectScore(5, "Physics");
            SubjectScore[] lewaSubjectScore = new SubjectScore[] { lewaMath, lewaPhysics };
            Candidate lewa = new Candidate(lewaPerson, lewaSubjectScore);


            Candidate[] candidates = new Candidate[] { vasya, kolya, olya, zuzya, lewa };
            short maxScore = 0;
            foreach (var cand in candidates)
            {
                Console.WriteLine(cand.Person.Address.Street);
                short temp = GetScore(cand, SUBJECT);
                if (GetScore(cand, SUBJECT) > maxScore)
                {
                    maxScore = GetScore(cand, SUBJECT);
                }
            }
            Console.WriteLine(maxScore);
        }
        static short GetScore(Candidate cand, string subj)
        {
            for (int j = 0; j < cand.SubjectScores.Length; j++)
            {
                if (cand.SubjectScores[j].ItemName == subj)
                {
                    return cand.SubjectScores[j].Score;
                }
            }
            return -1;
        }*/


            var kolya = new Person("Kolya", "Kolyakin", new Address(1, 1,"str", "city"));
            var kolyaCourses = new string[] { "Mathematics", "Physics" };
            var kolyaTeacher = new Teacher(kolya, 111, kolyaCourses);

            var petya = new Person("Petr", "Petrov",new Address(1, 2, "str", "city"));
            var petyaCourses = new string[] { "Mathematics" };
            var petyaTeacher = new Teacher(petya, 112, petyaCourses);

            var vasya = new Person("Vasya", "Pupkin", new Address(1, 3, "str", "city"));
            var vasyaCourses = new string[] { "Literature" };
            var vasyaTeacher = new Teacher(vasya, 113, vasyaCourses);

            var fedya = new Person("Fedya", "Kolyakin", new Address(1, 4, "str", "city"));
            var fedyaCourses = new string[] { "Mathematics", "Physics" };
            var fedyaTeacher = new DegreeTeacher(fedya, 114, fedyaCourses, "1st", "master");

            var tom = new Person("Tom", "Tomek",new Address(1, 5, "str", "city"));
            var tomSupportStaff = new SupportStaff(tom, 221, "Cleaner", "university building cleaning");

            var chrom = new Person("Chrom", "Chromuch", new Address(1, 6, "str", "city"));
            var chromSupportStaff = new SupportStaff(chrom, 222, "Security guard", "university building security");

            var universityEmployees = new UniversityEmployee[] { kolyaTeacher, petyaTeacher, vasyaTeacher,
                tomSupportStaff, chromSupportStaff, fedyaTeacher};

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




            var roomLaba = new Room("Laba");

            var korp1Rooms = new Room[] { roomLaba };
            var gikalo10 = new Address(10, "Gikalo", "Minsk");
            var korp1 = new Building(gikalo10, korp1Rooms);

            var korp2Rooms = new Room[] { roomLaba };
            var korp2 = new Building(new Address(11, "Gikalo", "Minsk"), korp2Rooms);

            var bsuirBuildings = new Building[] { korp1,korp2 };

            var semenAddress = new Address(5, 20, "Semenovskaya", "Sem");
            var semenSemenych = new Person("Semen", "Semenov", semenAddress);
            var semenRector = new Rector(semenSemenych, 555);
            var bsuir = new University(gikalo10, universityEmployees, semenRector, bsuirBuildings);

            Console.ReadLine();
        }
    }
}
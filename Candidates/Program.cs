
namespace Candidates
{

    internal class Program
    {
        const string SUBJECT = "Math";

       
        static void Main(string[] args)
        {
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
        }
    }
}
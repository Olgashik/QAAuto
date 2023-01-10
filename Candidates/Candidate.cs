using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class Candidate
    {
        public Person Person;
        public SubjectScore[] SubjectScores;

        public Candidate(Person person, SubjectScore[] subjectScores)
        {
            Person = person;
            SubjectScores = subjectScores;
        }
    }
}

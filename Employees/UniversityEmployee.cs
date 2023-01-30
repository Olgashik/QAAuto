namespace Employees
{
    internal class UniversityEmployee
    {
        private Person Person;
        private int TaxID; 
        
        public UniversityEmployee(Person person, int taxID)
        {
            Person = person;
            TaxID = taxID;
        }

        public virtual string GetOfficialDuties()
        {
            return string.Format("{0} {1}", Person.FirstName, Person.LastName);
        }

    }
}

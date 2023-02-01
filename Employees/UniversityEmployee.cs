namespace Employees
{
    internal abstract class UniversityEmployee
    {
        public Person Person { get; set; }
        
        private int _id;
        public int TaxId
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }

        
        public UniversityEmployee(Person person, int taxId)
        {
            Person = person;
            TaxId = taxId;
        }

        public virtual string GetOfficialDuties()
        {
            return string.Format("{0} {1}", Person.FirstName, Person.LastName);
        }

    }
}

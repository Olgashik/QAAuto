namespace Employees
{
    internal class SupportStaff: UniversityEmployee
    {
        public string OfficialDuty { get; }
        public string DescriptionDuty { get; }

        public SupportStaff(Person person, int taxID, string officialDuty, string descriptionDuty)
            : base (person, taxID)
        {
            OfficialDuty = officialDuty;
            DescriptionDuty = descriptionDuty;
        }

        public override string GetOfficialDuties()
        {
            return string.Format("{0} {1} {2}", base.GetOfficialDuties(), OfficialDuty, DescriptionDuty);
        }
    }
}

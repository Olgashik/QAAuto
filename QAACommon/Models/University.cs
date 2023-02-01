
namespace QAACommon.Models
{
    internal class University
    {
        public Address Address { get; set; }
        public UniversityEmployee[] UniversityEmployees { get; set; }
        public Rector Rector { get; set; }
        public Building[] Buildings { get; set; }
        public University(Address address, UniversityEmployee[] universityEmployees, Rector rector, Building[] buildings)
        {
            Address = address;
            UniversityEmployees = universityEmployees;
            Rector = rector;
            Buildings = buildings;
        }
    }
}

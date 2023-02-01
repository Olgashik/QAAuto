
namespace QAACommon.Models
{
    internal class Building
    {
        public Address Address { get; set; }
        public Room[] Rooms { get; set; }
        public Building(Address address, Room[] rooms)
        {
            Address = address;
            Rooms = rooms;
        }
    }
}

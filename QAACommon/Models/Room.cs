
namespace QAACommon.Models
{
    internal class Room
    {
        public string RoomType { get; set; }
        public Room(string roomType)
        {
            RoomType = roomType;
        }
    }
}

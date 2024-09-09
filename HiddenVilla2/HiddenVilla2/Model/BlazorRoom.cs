using System.Collections.Generic;

namespace HiddenVilla2.Model
{
    public class BlazorRoom
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public bool IsActive { get; set; }
        public double Price { get; set; }
        public List<BlazorRoomProp> RoomProps { get; set; }

    }
}

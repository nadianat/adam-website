using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class RoomViewModel
    {
        public string roomType { get; set; }
        public byte[] roomTypePic { get; set; }
        public double pricePerNight { get; set; }
        public int numberOfRoomTypeAvailable { get; set; }
        public int AdultCapacity { get; set; }
        public int ChildCapacity { get; set; }
        public IEnumerable<RoomDetailViewModel> room_char { get; set; }
    }
}

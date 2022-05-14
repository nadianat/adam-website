using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Services.ViewModel
{
    public class HotelInfoViewModel
    {
        public string HotelName { get; set; }
        public string HotelID { get; set; }
        public string HotelImageURL { get; set; }
        public IEnumerable<RoomInfoViewModel> HotelRooms { get; set; }
    }
}

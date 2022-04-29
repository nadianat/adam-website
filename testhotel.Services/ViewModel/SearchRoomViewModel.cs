using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class SearchRoomViewModel
    {
        public byte[] hotelLogo { get; set; }
        public IEnumerable<string> AllHotels { get; set; }
        public int maxAdultCapacity { get; set; }
        public int maxChildCapacity { get; set; }
        public DateTime check_in_fill { get; set; }
        public DateTime check_out_fill { get; set; }
        public int adult_fill { get; set; }
        public int child_fill { get; set; }
        public string hotel_fill { get; set; }
        public int numberOfNights { get; set; }
        public string hotelName { get; set; }
        public IEnumerable<RoomViewModel> rooms { get; set; }
    }
}

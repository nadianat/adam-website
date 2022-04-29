using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class HotelInfoViewModel
    {
        public byte[] hotelLogo { get; set; }
        public IEnumerable<byte[]> DashBoardPics { get; set; }
        public IEnumerable<string> AllHotels { get; set; }
        public int maxAdultCapacity { get; set; }
        public int maxChildCapacity { get; set; }

    }
}

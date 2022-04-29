using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class BookRoomViewModel
    {
        public DateTime check_in_fill { get; set; }
        public DateTime check_out_fill { get; set; }
        public int adult_fill { get; set; }
        public int child_fill { get; set; }
        public IEnumerable<SelectedRoomViewModel> rooms { get; set; }
        public double totalCostRooms { get; set; }
        public string hotelName { get; set; }
    }
}

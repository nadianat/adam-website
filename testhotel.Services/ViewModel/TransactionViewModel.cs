using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class TransactionViewModel
    {
        public byte[] hotelLogo { get; set; }
        public BookRoomViewModel selectedRooms { get; set; }
        public IEnumerable<AddOnViewModel> availableAddOns { get; set; }
        public CustomerInfoViewModel customerInfo { get; set; }
        public GuestInfoViewModel guestInfo { get; set; }
        public IEnumerable<SelectedAddOnViewModel> selectedAddOns { get; set; }
        public double AddOnPlusRooms { get; set; }
        public double AddOnPlusRoomsAfterTax { get; set; }
        public PaymentInfoViewModel payment { get; set; }
        public string TransactionId { get; set; }
    }
}

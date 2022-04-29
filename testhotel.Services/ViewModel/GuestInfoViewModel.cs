using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class GuestInfoViewModel
    {
        public string GuestId { get; set; }
        public string GuestFirstName { get; set; }
        public string GuestLastName { get; set; }
        public string Gender { get; set; }
        public Address address { get; set; }
        public string ICNumber { get; set; }
        public ContactNumber contactNumber { get; set; }
        public string emailAddress { get; set; }
        public CustomerInfoViewModel bookCus { get; set; }
    }
}

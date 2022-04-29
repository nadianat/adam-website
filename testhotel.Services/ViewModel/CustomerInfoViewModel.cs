using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class CustomerInfoViewModel
    {
        public string CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Gender { get; set; }
        public Address address { get; set; }
        public string ICNumber { get; set; }
        public ContactNumber contactNumber { get; set; }
        public string emailAddress { get; set; }
        public string haveGuest { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class ContactNumber
    {
        public string CountryCode { get; set; }
        public string contactNumber { get; set; }
    }

    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}

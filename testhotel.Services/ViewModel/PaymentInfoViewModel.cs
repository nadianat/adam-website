using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class PaymentInfoViewModel
    {
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public int CVV { get; set; }
    }
}

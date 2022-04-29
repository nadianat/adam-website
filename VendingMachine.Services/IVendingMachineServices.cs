using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Services.ViewModel;

namespace VendingMachine.Services
{
    public interface IVendingMachineServices
    {
        HotelInfoViewModel GetHotelInfo();
    }
}

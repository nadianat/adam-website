#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testhotel.Web.Data;
using testhotel.Web.Models;
using VendingMachine.Services.ViewModel;
using VendingMachine.Services;

namespace testhotel.Web.Controllers
{
    public class ReservationsController : Controller
    {
        public readonly VendingMachineServices VMServices = new VendingMachineServices();

        // GET: Reservations/Create
        [HttpGet]
        public ActionResult Create()
        {
            HotelInfoViewModel hotelInfo = VMServices.GetHotelInfo();
            return View(hotelInfo);
        }
    }


}

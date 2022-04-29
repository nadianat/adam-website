using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Entities;
using VendingMachine.Services.ViewModel;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace VendingMachine.Services
{
    public class VendingMachineServices : IVendingMachineServices
    {
        //get hotel info for dashboard page
        public HotelInfoViewModel GetHotelInfo()
        {
            using (var dbContext = new vending_machine_databaseEntities())
            {
                var hotelid = '1'.ToString();
                HotelInfoViewModel hotelinfooutput = new HotelInfoViewModel();// create hotelinfo obj
                IList<RoomInfoViewModel> RoomList = new List<RoomInfoViewModel>(); // create room list in hotel
                var hotelInfo = from h in dbContext.Hotels
                                join r in dbContext.Products
                                on h.Hotel_ID equals r.Hotel_ID into hotels
                                where h.Hotel_ID == hotelid
                                from hr in hotels
                                join rt in dbContext.Product_Type on hr.Product_Type_ID equals rt.Product_Type_ID
                                select new
                                {
                                    h.Hotel_ID,
                                    h.Hotel_Name,
                                    h.HotelImgURL,
                                    h.Products,
                                };

                hotelinfooutput.HotelImageURL = hotelInfo.First().HotelImgURL;
                hotelinfooutput.HotelName = hotelInfo.First().Hotel_Name;
                hotelinfooutput.HotelID = hotelInfo.First().Hotel_ID;
                foreach (var hotelroom in hotelInfo.First().Products)
                {
                    var room = new RoomInfoViewModel();
                    room.HotelID = hotelroom.Hotel_ID;
                    room.RoomPrice = hotelroom.Price;
                    room.RoomName = hotelroom.Product_Type.Name;
                    room.RoomID = hotelroom.Product_ID;
                    room.RoomTypeID = hotelroom.Product_Type_ID;
                    room.RoomDescription = hotelroom.Remarks;
                    room.RoomImgURL = hotelroom.Product_Type.ImageUrl;
                    RoomList.Add(room);
                }

                hotelinfooutput.HotelRooms = RoomList;
                return hotelinfooutput;

            }

        }
    }
}
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Services.ViewModel
{
    public class RoomInfoViewModel
    {
        public string RoomName { get; set; }

        //[DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(19, 2)")]
        //[DisplayFormat(DataFormatString = "{0:C0}")]
        public double RoomPrice { get; set; }
        public string RoomImgURL { get; set; }
        public string HotelID { get; set; }
        public string RoomID { get; set; }
        public string RoomTypeID { get; set; }
        public string RoomDescription { get; set; }

    }

    public class Mainrequests
    {
        public List<requests> requests { get; set; }
    }
    public class requests
    {
        public image CustomerICPic { get; set; }

        public List<features> features { get; set; }
    }

    public class image
    {
        public string content { get; set; }
    }
    public class features
    {
        public string type { get; set; }
    }
}

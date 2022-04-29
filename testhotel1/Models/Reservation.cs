using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testhotel.Web.Models
{
    public class Reservation
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Check-In Date"), DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Display(Name = "Check-Out Date"), DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        
        [Required]
        [Display(Name = "Room Type")]
        public string? RoomType { get; set; }

        [Display(Name = "Guest Amount")]
        public int GuestAmount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        //[NotMapped]
        //public string CheckInDate => CheckInDate.ToString("dd/MM/yyyy");
        //[NotMapped]
        //public string CheckOutDate => CheckOutDate.ToString("dd/MM/yyyy");
    }
}

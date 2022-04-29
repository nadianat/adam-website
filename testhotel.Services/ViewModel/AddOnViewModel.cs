using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhotel.Services.ViewModel
{
    public class AddOnViewModel
    {
        public string Add_On_Name { get; set; }
        public string Add_On_Description { get; set; }
        public byte[] Add_On_Pic { get; set; }
        public double Add_On_Price { get; set; }
        public int Max_Add_On { get; set; }
    }
}

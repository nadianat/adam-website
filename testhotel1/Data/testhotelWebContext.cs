#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testhotel.Web.Models;

namespace testhotel.Web.Data
{
    public class testhotelWebContext : DbContext
    {
        public testhotelWebContext (DbContextOptions<testhotelWebContext> options)
            : base(options)
        {
        }

        public DbSet<testhotel.Web.Models.Reservation> Reservation { get; set; }
    }
}

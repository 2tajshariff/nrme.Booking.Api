using Microsoft.EntityFrameworkCore;

namespace nrme.Booking.Api.DBContext
{
    public class NRMEDBContext : DbContext
    {
        public NRMEDBContext(DbContextOptions<NRMEDBContext> options): base(options)
        {
            
        }

        public DbSet<Models.Booking> Appointments { get; set; }
    }
}

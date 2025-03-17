using Microsoft.EntityFrameworkCore;

namespace rv_app_fullstack.Server.Models
{
    public class LocationContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
    }
}

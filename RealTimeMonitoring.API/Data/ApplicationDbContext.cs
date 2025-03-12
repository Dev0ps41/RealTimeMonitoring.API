using Microsoft.EntityFrameworkCore;
using RealTimeMonitoring.API.Models;  //  important

namespace RealTimeMonitoring.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //  full namespace to avoid ambiguity
        public DbSet<RealTimeMonitoring.API.Models.ProductionData> ProductionData { get; set; }
    }
}

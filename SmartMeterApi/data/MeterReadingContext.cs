using Microsoft.EntityFrameworkCore;
using SmartMeterApi.Models;

namespace SmartMeterApi.Data
{
    public class MeterReadingContext : DbContext
    {
        public MeterReadingContext(DbContextOptions<MeterReadingContext> options)
            : base(options) { }

        public DbSet<MeterReading> MeterReadings { get; set; }
    }
}

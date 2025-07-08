using Microsoft.AspNetCore.Mvc;
using SmartMeterApi.Data;
using SmartMeterApi.Models;

namespace SmartMeterApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeterReadingController : ControllerBase
    {
        private readonly MeterReadingContext _context;

        public MeterReadingController(MeterReadingContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<MeterReading>> PostReading(MeterReading reading)
        {
            _context.MeterReadings.Add(reading);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(PostReading), new { id = reading.Id }, reading);
        }

        [HttpGet]
        public ActionResult<IEnumerable<MeterReading>> GetReadings()
        {
            return _context.MeterReadings.ToList();
        }
    }
}

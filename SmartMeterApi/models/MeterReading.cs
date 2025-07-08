namespace SmartMeterApi.Models
{
    public class MeterReading
    {
        public int Id { get; set; }
        public required string ReadingDate { get; set; }
        public required string ReadingTime { get; set; }
        public double EnergyUsed { get; set; }
    }
}

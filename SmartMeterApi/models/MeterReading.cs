namespace SmartMeterApi.Models
{
    public class MeterReading
    {
        public int Id { get; set; }
        public DateOnly ReadingDate { get; set; }
        public TimeOnly ReadingTime { get; set; }
        public double EnergyUsed { get; set; }
    }
}

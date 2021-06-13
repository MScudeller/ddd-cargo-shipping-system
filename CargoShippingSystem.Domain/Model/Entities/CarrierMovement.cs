using CargoShippingSystem.Domain.Model.ValueObjects;

namespace CargoShippingSystem.Domain.Model.Entities
{
    public class CarrierMovement
    {
        public string ScheduleId { get; set; }
        public Location From { get; set; }
        public Location To { get; set; }
    }
}
using CargoShippingSystem.Domain.Model.Entities;
using CargoShippingSystem.Domain.Model.ValueObjects;

namespace CargoShippingSystem.Infrastructure.Repositories
{
    public class CarrierMovementRepository : ICarrierMovementRepository
    {
        public CarrierMovement FindByScheduleId(string scheduleId)
        {
            return null;
        }
        
        public CarrierMovement FindByFromTo(Location from, Location to)
        {
            return null;
        }
    }
}
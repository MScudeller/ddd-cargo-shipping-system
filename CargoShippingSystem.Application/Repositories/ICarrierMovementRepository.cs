using CargoShippingSystem.Domain.Model.Entities;
using CargoShippingSystem.Domain.Model.ValueObjects;

namespace CargoShippingSystem.Infrastructure.Repositories
{
    public interface ICarrierMovementRepository
    {
        CarrierMovement FindByScheduleId(string scheduleId);
        CarrierMovement FindByFromTo(Location from, Location to);
    }
}
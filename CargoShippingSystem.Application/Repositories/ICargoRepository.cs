using CargoShippingSystem.Domain.Model.Entities;

namespace CargoShippingSystem.Application.Repositories
{
    public interface ICargoRepository
    {
        Cargo? FindByCargoTrackingId(string cargoTrackingId);

        Cargo? FindByCustomerId(string customerId);
    }
}
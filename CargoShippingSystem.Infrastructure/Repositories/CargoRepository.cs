using CargoShippingSystem.Application.Repositories;
using CargoShippingSystem.Domain.Model.Entities;

namespace CargoShippingSystem.Infrastructure.Repositories
{
    public class CargoRepository : ICargoRepository

    {
    public Cargo FindByCargoTrackingId(string cargoTrackingId)
    {
        return null;
    }

    public Cargo FindByCustomerId(string customerId)
    {
        return null;
    }
    }
}
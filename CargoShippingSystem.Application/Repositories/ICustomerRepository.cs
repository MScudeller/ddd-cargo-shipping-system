using CargoShippingSystem.Domain.Model.Entities;

namespace CargoShippingSystem.Infrastructure.Repositories
{
    public interface ICustomerRepository
    {
        Customer FindById(string id);
        Customer FindByName(string name);
        Customer FindByCargoTrackingId(string cargoTrackingId);
    }
}
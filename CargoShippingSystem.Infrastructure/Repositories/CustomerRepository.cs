using CargoShippingSystem.Domain.Model.Entities;

namespace CargoShippingSystem.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer FindById(string id)
        {
            return null;
        }
        
        public Customer FindByName(string name)
        {
            return null;
        }
        
        public Customer FindByCargoTrackingId(string cargoTrackingId)
        {
            return null;
        }
    }
}
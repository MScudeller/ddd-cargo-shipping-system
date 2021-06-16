using CargoShippingSystem.Domain.Model.ValueObjects;

namespace CargoShippingSystem.Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        public Location FindByPortCode(string portCode)
        {
            return null;
        }
        
        public Location FindByCityName(string cityName)
        {
            return null;
        }
    }
}
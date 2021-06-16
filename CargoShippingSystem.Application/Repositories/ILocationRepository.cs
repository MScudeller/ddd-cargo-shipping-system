using CargoShippingSystem.Domain.Model.ValueObjects;

namespace CargoShippingSystem.Infrastructure.Repositories
{
    public interface ILocationRepository
    {
        Location FindByPortCode(string portCode);
        Location FindByCityName(string cityName);
    }
}
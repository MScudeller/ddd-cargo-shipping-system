using CargoShippingSystem.Application.Repositories;
using CargoShippingSystem.Domain.Model.Entities;

namespace CargoShippingSystem.Application
{
    public class IncidentLogging
    {
        private readonly ICargoRepository cargoRepository;

        public IncidentLogging(ICargoRepository cargoRepository)
        {
            this.cargoRepository = cargoRepository;
        }

        public void RecordHandling(Cargo cargo, HandlingEvent handlingEvent)
        {
            cargo.DeliveryHistory.HandlingEvents.Add(handlingEvent);
            //cargoRepository.Save(cargo);
        }
    }
}
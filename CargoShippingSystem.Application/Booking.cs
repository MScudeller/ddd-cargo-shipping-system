using CargoShippingSystem.Application.Repositories;
using CargoShippingSystem.Domain.Model.Entities;
using CargoShippingSystem.Domain.Model.ValueObjects;

namespace CargoShippingSystem.Application
{
    public class Booking
    {
        private readonly ICargoRepository cargoRepository;

        public Booking(ICargoRepository cargoRepository)
        {
            this.cargoRepository = cargoRepository;
        }

        public void BookNewCargo(Cargo cargo)
        {
            //cargoRepository.AddCargo(cargo);
        }

        public void ChangeCargoDestination(Cargo cargo, Location location)
        {
            cargo.Goal = new DeliverySpecification
            {
                ArrivalTime = cargo.Goal.ArrivalTime, 
                Destination = location,
            };
        }

        public void RepeatBooking(string cargoId)
        {
            //var cargo = cargoRepository.FindByCargoTrackingId(cargoId)?.Clone();
            //cargoRepository.AddCargo(cargo);
        }
    }
}
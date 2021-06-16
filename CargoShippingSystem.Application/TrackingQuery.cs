using System;
using CargoShippingSystem.Application.Repositories;
using CargoShippingSystem.Domain.Model.Entities;

namespace CargoShippingSystem.Application
{
    public class TrackingQuery
    {
        private readonly ICargoRepository cargoRepository;

        public TrackingQuery(ICargoRepository cargoRepository)
        {
            this.cargoRepository = cargoRepository;
        }

        public Cargo AccessCargo(string cargoId)
        {
            return cargoRepository.FindByCargoTrackingId(cargoId);
        }
    }
}
using System;

namespace CargoShippingSystem.Domain.Model.ValueObjects
{
    public class DeliverySpecification
    {
        public DateTime ArrivalTime { get; set; }
        public Location Destination { get; set; }
    }
}
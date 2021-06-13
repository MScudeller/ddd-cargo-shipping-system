using System.Collections.Generic;
using CargoShippingSystem.Domain.Model.ValueObjects;

namespace CargoShippingSystem.Domain.Model.Entities
{
    public class Cargo
    {
        public string TrackingId { get; set; }
        public Dictionary<Role,Customer> Customers { get; set; }
        public DeliveryHistory DeliveryHistory { get; set; }
        public DeliverySpecification Goal { get; set; }
    }
}
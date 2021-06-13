using System.Collections.Generic;

namespace CargoShippingSystem.Domain.Model.Entities
{
    public class DeliveryHistory
    {
        public Cargo Cargo { get; set; }
        public List<HandlingEvent> HandlingEvents { get; set; }
    }
}
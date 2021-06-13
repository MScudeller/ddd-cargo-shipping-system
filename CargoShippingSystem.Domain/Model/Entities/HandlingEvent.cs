using System;

namespace CargoShippingSystem.Domain.Model.Entities
{
    public abstract class HandlingEvent
    {
        public DateTime CompletionTime { get; set; }
        public string Type { get; set; }
        public Cargo Handled { get; set; }
        public CarrierMovement? CarrierMovement { get; set; }
    }
}
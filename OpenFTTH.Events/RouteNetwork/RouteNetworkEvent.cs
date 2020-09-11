using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public abstract class RouteNetworkEvent : DomainEvent
    {
        public RouteNetworkEvent(string eventType, Guid eventId, DateTime eventTimestamp)
            : base(eventType, eventId, eventTimestamp)
        {
        }
    }
}

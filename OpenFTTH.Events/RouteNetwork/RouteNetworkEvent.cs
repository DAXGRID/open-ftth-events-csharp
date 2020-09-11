using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public abstract class RouteNetworkEvent : DomainEvent
    {
        public RouteNetworkEvent(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo)
            : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
        }
    }
}

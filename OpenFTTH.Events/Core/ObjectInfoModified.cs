using OpenFTTH.Events.RouteNetwork;
using System;

namespace OpenFTTH.Events.Core
{
    public class ObjectInfoModified : RouteNetworkEvent
    {
        private readonly Guid _aggregateId;
        public Guid AggregateId => _aggregateId;

        private readonly string _aggregateType;
        public string AggregateType => _aggregateType;

        public ObjectInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, Guid aggregateId, string aggregateType)
          : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _aggregateId = aggregateId;
            _aggregateType = aggregateType;
        }
    }
}

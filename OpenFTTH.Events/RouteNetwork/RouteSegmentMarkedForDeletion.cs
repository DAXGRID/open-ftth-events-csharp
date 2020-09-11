using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteSegmentMarkedForDeletion : RouteNetworkEvent
    {
        private readonly Guid _segmentId;
        public Guid SegmentId => _segmentId;

        public RouteSegmentMarkedForDeletion(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, Guid segmentId) 
            : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _segmentId = segmentId;
        }
    }
}

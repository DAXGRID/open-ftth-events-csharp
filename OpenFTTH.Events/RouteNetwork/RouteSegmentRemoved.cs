using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteSegmentRemoved : RouteNetworkEvent
    {
        private readonly Guid _segmentId;
        public Guid SegmentId => _segmentId;

        private readonly Guid[] _replacedBySegments;
        public Guid[] ReplacedBySegments => _replacedBySegments;

        public RouteSegmentRemoved(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, Guid segmentId, Guid[] replacedBySegments) 
            : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _segmentId = segmentId;
            _replacedBySegments = replacedBySegments;
        }
    }
}

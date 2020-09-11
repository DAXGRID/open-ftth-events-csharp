using OpenFTTH.Events.Core.Infos;
using OpenFTTH.Events.RouteNetwork.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteSegmentInfoModified : RouteNetworkEvent
    {
        private readonly Guid _segmentId;
        public Guid SegmentId => _segmentId;

        private readonly RouteSegmentInfo? _routeSegmentInfo;
        public RouteSegmentInfo? RouteSegmentInfo => _routeSegmentInfo;

        public RouteSegmentInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, Guid segmentId, RouteSegmentInfo? routeSegmentInfo)
          : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _segmentId = segmentId;
            _routeSegmentInfo = routeSegmentInfo;
        }
    }
}

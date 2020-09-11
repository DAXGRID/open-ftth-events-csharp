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

        public RouteSegmentInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, Guid segmentId, RouteSegmentInfo? routeSegmentInfo)
          : base(eventType, eventId, eventTimestamp)
        {
            _segmentId = segmentId;
            _routeSegmentInfo = routeSegmentInfo;
        }
    }
}

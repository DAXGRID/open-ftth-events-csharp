using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteSegmentGeometryModified : RouteNetworkEvent
    {
        private readonly Guid _segmentId;
        public Guid SegmentId => _segmentId;

        private readonly string _geometry;
        public string Geometry => _geometry;

        public RouteSegmentGeometryModified(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, Guid segmentId, string geometry) 
            : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _segmentId = segmentId;
            _geometry = geometry;
        }
    }
}

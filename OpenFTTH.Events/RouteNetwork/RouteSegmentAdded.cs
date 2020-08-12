using OpenFTTH.Events.Core.Infos;
using OpenFTTH.Events.RouteNetwork.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteSegmentAdded : RouteElementAddedEvent
    {
        private readonly Guid _segmentId;
        public Guid SegmentId => _segmentId;

        private readonly Guid _fromNodeId;
        public Guid FromNodeId => _fromNodeId;

        private readonly Guid _toNodeId;
        public Guid ToNodeId => _toNodeId;

        private readonly string _geometry;
        public string Geometry => _geometry;

        private readonly RouteSegmentInfo? _routeSegmentInfo;
        public RouteSegmentInfo? RouteSegmentInfo => _routeSegmentInfo;
        
        public RouteSegmentAdded(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, NamingInfo? namingInfo, LifecycleInfo? lifecyleInfo, MappingInfo? mappingInfo, SafetyInfo? safetyInfo, Guid segmentId, Guid fromNodeId, Guid toNodeId, string geometry, RouteSegmentInfo? routeSegmentInfo) 
            : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo, namingInfo, lifecyleInfo, mappingInfo, safetyInfo)
        {
            _segmentId = segmentId;
            _fromNodeId = fromNodeId;
            _toNodeId = toNodeId;
            _geometry = geometry;
            _routeSegmentInfo = routeSegmentInfo;
        }
    }
}

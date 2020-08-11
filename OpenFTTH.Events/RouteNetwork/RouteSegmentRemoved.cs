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

        public RouteSegmentRemoved(string eventType, Guid eventId, string cmdType, Guid cmdId, Guid segmentId, Guid[] replacedBySegments, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo) 
            : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _segmentId = segmentId;
            _replacedBySegments = replacedBySegments;
        }
    }
}

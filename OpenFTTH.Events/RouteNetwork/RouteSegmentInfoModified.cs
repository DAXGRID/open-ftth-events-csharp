using OpenFTTH.Events.Core.Infos;
using OpenFTTH.Events.RouteNetwork.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteSegmentInfoModified : RouteNetworkEvent
    {
        private readonly RouteSegmentInfo? _routeSegmentInfo;
        public RouteSegmentInfo? RouteSegmentInfo => _routeSegmentInfo;

        public RouteSegmentInfoModified(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, RouteSegmentInfo? routeSegmentInfo)
          : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _routeSegmentInfo = routeSegmentInfo;
        }
    }
}

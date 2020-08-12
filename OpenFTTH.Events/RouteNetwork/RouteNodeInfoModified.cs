using OpenFTTH.Events.Core.Infos;
using OpenFTTH.Events.RouteNetwork.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteNodeInfoModified : RouteNetworkEvent
    {
        private readonly Guid _nodeId;
        public Guid NodeId => _nodeId;

        private readonly RouteNodeInfo? _routeNodeInfo;
        public RouteNodeInfo? RouteNodeInfo => _routeNodeInfo;

        public RouteNodeInfoModified(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, Guid nodeId, RouteNodeInfo? routeNodeInfo)
          : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _nodeId = nodeId;
            _routeNodeInfo = routeNodeInfo;
        }
    }
}

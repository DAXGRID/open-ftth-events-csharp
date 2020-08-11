using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteNodeMarkedForDeletion : RouteNetworkEvent
    {
        private readonly Guid _nodeId;
        public Guid NodeId => _nodeId;

        public RouteNodeMarkedForDeletion(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, Guid nodeId) 
            : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _nodeId = nodeId;
        }
    }
}

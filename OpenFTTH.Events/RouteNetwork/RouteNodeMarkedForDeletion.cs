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

        public RouteNodeMarkedForDeletion(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, Guid nodeId) 
            : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _nodeId = nodeId;
        }
    }
}

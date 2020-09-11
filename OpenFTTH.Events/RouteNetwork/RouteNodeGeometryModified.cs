using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteNodeGeometryModified : RouteNetworkEvent
    {
        private readonly Guid _nodeId;
        public Guid NodeId => _nodeId;

        private readonly string _geometry;
        public string Geometry => _geometry;

        public RouteNodeGeometryModified(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, Guid nodeId, string geometry) 
            : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _nodeId = nodeId;
            _geometry = geometry;
        }
    }
}

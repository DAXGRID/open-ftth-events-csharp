using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteNetworkEditOperationOccuredEvent : DomainEvent
    {
        private readonly Guid? _workTaskMrid;
        public Guid? WorkTaskMrid => _workTaskMrid;

        private readonly string? _userName;
        public string? UserName => _userName;

        public RouteNetworkCommand[] RouteNetworkCommands { get; set; }

        public RouteNetworkEditOperationOccuredEvent(string eventType, Guid eventId, DateTime eventTimestamp, Guid? workTaskMrid, string? userName, string? applicationName, string? applicationInfo, RouteNetworkCommand[] commands) : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _workTaskMrid = workTaskMrid;
            _userName = userName;
            RouteNetworkCommands = commands;
        }
    }
}

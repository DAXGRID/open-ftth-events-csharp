using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public abstract class RouteNetworkEvent : CommandEvent
    {
        public RouteNetworkEvent(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo)
            : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
        }
    }
}

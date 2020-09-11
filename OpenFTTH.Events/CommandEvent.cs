using OpenFTTH.Events.RouteNetwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events
{
    /// <summary>
    /// An event resulted from a command.
    /// Typical a user triggered command of some kind, but can also be a system triggered command.
    /// </summary>
    public class CommandEvent : DomainEvent
    {
        private readonly string _cmdType;
        public string CmdType => _cmdType;

        private readonly Guid _cmdId;
        public Guid CmdId => _cmdId;
     
        private readonly Guid? _workTaskMrid;
        public Guid? WorkTaskMrid => _workTaskMrid;

        private readonly string? _userName;
        public string? UserName => _userName;

        public RouteNetworkEvent[] _events;
        public RouteNetworkEvent[] RouteNetworkEvent => _events;

        public CommandEvent(string eventType, Guid eventId, DateTime eventTimestamp, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid? workTaskMrid, string? userName, string? applicationName, string? applicationInfo, RouteNetworkEvent[] events) : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _cmdType = cmdType;
            _cmdId = cmdId;
            _workTaskMrid = workTaskMrid;
            _userName = userName;
            _events = events;
        }
    }
}

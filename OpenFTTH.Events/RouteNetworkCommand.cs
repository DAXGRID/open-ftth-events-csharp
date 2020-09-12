using OpenFTTH.Events.RouteNetwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events
{
    /// <summary>
    /// A command that can hold one of more related events.
    /// Typical a user triggered command of some kind, but can also be a system triggered command.
    /// </summary>
    public class RouteNetworkCommand
    {
        private readonly string _cmdType;
        public string CmdType => _cmdType;

        private readonly Guid _cmdId;
        public Guid CmdId => _cmdId;

        private readonly RouteNetworkEvent[] _routeNetworkEvents;
        public RouteNetworkEvent[] RouteNetworkEvents => _routeNetworkEvents;

        public RouteNetworkCommand(string cmdType, Guid cmdId, RouteNetworkEvent[] routeNetworkEvents)
        {
            _cmdType = cmdType;
            _cmdId = cmdId;
            _routeNetworkEvents = routeNetworkEvents;
        }
    }
}

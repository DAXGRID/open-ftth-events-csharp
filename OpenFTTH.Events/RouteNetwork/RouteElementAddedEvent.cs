using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public abstract class RouteElementAddedEvent : RouteNetworkEvent
    {
        private readonly LifecyleInfo? _lifecyleInfo;
        public LifecyleInfo? LifecyleInfo => _lifecyleInfo;

        private readonly MappingInfo? _mappingInfo;
        public MappingInfo? MappingInfo => _mappingInfo;

        private readonly SafetyInfo? _safetyInfo;
        public SafetyInfo? SafetyInfo => _safetyInfo;


        public RouteElementAddedEvent(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, LifecyleInfo? lifecyleInfo, MappingInfo? mappingInfo, SafetyInfo? safetyInfo)
            : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _lifecyleInfo = lifecyleInfo;
            _mappingInfo = mappingInfo;
            _safetyInfo = safetyInfo;
        }
    }
}

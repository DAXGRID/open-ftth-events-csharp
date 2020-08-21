using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public abstract class RouteElementAddedEvent : RouteNetworkEvent
    {
        private readonly NamingInfo? _namingInfo;
        public NamingInfo? NamingInfo => _namingInfo;

        private readonly LifecycleInfo? _lifecyleInfo;
        public LifecycleInfo? LifecyleInfo => _lifecyleInfo;

        private readonly MappingInfo? _mappingInfo;
        public MappingInfo? MappingInfo => _mappingInfo;

        private readonly SafetyInfo? _safetyInfo;
        public SafetyInfo? SafetyInfo => _safetyInfo;


        public RouteElementAddedEvent(string eventType, Guid eventId, DateTime eventTimestamp, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, NamingInfo? namingInfo, LifecycleInfo? lifecyleInfo, MappingInfo? mappingInfo, SafetyInfo? safetyInfo)
            : base(eventType, eventId, eventTimestamp, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _namingInfo = namingInfo;
            _lifecyleInfo = lifecyleInfo;
            _mappingInfo = mappingInfo;
            _safetyInfo = safetyInfo;
        }
    }
}

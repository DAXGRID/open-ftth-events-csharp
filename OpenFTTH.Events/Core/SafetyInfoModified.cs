using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class SafetyInfoModified : CommandEvent
    {
        private readonly SafetyInfo? _safetyInfo;
        public SafetyInfo? SafetyInfo => _safetyInfo;

        public SafetyInfoModified(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, SafetyInfo? safetyInfo)
          : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _safetyInfo = safetyInfo;
        }
    }
}

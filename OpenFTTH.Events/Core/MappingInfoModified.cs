using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class MappingInfoModified : CommandEvent
    {
        private readonly MappingInfo? _mappingInfo;
        public MappingInfo? MappingInfo => _mappingInfo;

        public MappingInfoModified(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, MappingInfo? mappingInfo)
          : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _mappingInfo = mappingInfo;
        }
    }
}

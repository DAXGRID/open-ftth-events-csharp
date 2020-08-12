using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class NamingInfoModified : CommandEvent
    {
        private readonly NamingInfo? _namingInfo;
        public NamingInfo? NamingInfo => _namingInfo;

        public NamingInfoModified(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, NamingInfo? namingInfo)
          : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _namingInfo = namingInfo;
        }
    }
}

using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class LifecycleInfoModified : ObjectInfoModified
    {
        private readonly LifecycleInfo? _lifecycleInfo;
        public LifecycleInfo? LifecycleInfo => _lifecycleInfo;

        public LifecycleInfoModified(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, Guid aggregateId, string aggregateType, LifecycleInfo? lifecycleInfo)
          : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo, aggregateId, aggregateType)
        {
            _lifecycleInfo = lifecycleInfo;
        }
    }
}

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

        public LifecycleInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, Guid aggregateId, string aggregateType, LifecycleInfo? lifecycleInfo)
          : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo, aggregateId, aggregateType)
        {
            _lifecycleInfo = lifecycleInfo;
        }
    }
}

using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class SafetyInfoModified : ObjectInfoModified
    {
        private readonly SafetyInfo? _safetyInfo;
        public SafetyInfo? SafetyInfo => _safetyInfo;

        public SafetyInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, Guid aggregateId, string aggregateType, SafetyInfo? safetyInfo)
          : base(eventType, eventId, eventTimestamp, aggregateId, aggregateType)
        {
            _safetyInfo = safetyInfo;
        }
    }
}

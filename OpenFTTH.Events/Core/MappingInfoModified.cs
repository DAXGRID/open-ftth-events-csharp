using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class MappingInfoModified : ObjectInfoModified
    {
        private readonly MappingInfo? _mappingInfo;
        public MappingInfo? MappingInfo => _mappingInfo;

        public MappingInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, Guid aggregateId, string aggregateType, MappingInfo? mappingInfo)
          : base(eventType, eventId, eventTimestamp, aggregateId, aggregateType)
        {
            _mappingInfo = mappingInfo;
        }
    }
}

using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class NamingInfoModified : ObjectInfoModified
    {
        private readonly NamingInfo? _namingInfo;
        public NamingInfo? NamingInfo => _namingInfo;

        public NamingInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, Guid aggregateId, string aggregateType, NamingInfo? namingInfo)
          : base(eventType, eventId, eventTimestamp, aggregateId, aggregateType)
        {
            _namingInfo = namingInfo;
        }
    }
}

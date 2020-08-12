using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class ObjectInfoModified : CommandEvent
    {
        private readonly Guid _aggregateId;
        public Guid AggregateId => _aggregateId;

        private readonly string _aggregateType;
        public string AggregateType => _aggregateType;

        public ObjectInfoModified(string eventType, Guid eventId, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, Guid aggregateId, string aggregateType)
          : base(eventType, eventId, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo)
        {
            _aggregateId = aggregateId;
            _aggregateType = aggregateType;
        }
    }
}

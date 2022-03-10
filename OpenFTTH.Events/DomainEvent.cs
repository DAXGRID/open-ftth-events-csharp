using MediatR;
using System;

namespace OpenFTTH.Events
{
    /// <summary>
    /// Mandatory event attributes, that all events in the Open FTTH system must implement
    /// </summary>
    public class DomainEvent : IDomainEvent, IRequest
    {
        public long EventSequenceNumber { get; set; }

        private readonly string _eventType;
        public string EventType => _eventType;

        private readonly Guid _eventId;
        public Guid EventId => _eventId;

        private readonly DateTime _eventTimestamp;
        public DateTime EventTimestamp => _eventTimestamp;

        private readonly string? _applicationName;
        public string? ApplicationName => _applicationName;

        private readonly string? _applicationInfo;
        public string? ApplicationInfo => _applicationInfo;

        public DomainEvent(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo)
        {
            _eventType = eventType;
            _eventId = eventId;
            _eventTimestamp = eventTimestamp;
            _applicationName = applicationName;
            _applicationInfo = applicationInfo;
        }
    }
}

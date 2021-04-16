using System;

namespace OpenFTTH.Events
{
    public abstract record EventStoreBaseEvent : IDomainEvent
    {
        public long EventSequenceNumber { get; init; }
        public Guid EventId { get; init; }
        public DateTime EventTimestamp { get; init; }
        public string? ApplicationName { get; init; }
        public string? ApplicationInfo { get; init; }
        public string? UserName { get; init; }
        public Guid WorkTaskId { get; init; }

        public string EventType => this.GetType().Name;
    }
}

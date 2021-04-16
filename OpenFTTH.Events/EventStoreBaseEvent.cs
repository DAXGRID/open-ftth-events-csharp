using System;

namespace OpenFTTH.Events
{
    public abstract record EventStoreBaseEvent
    {
        public long? IncitingEventSequenceNumber { get; init; }
        public DateTime? IncitingEventTimestamp { get; init; }
        public Guid? IncitingEventId { get; init; }
        public Guid? IncitingCmdId { get; init; }
        public string? ApplicationName { get; init; }
        public string? ApplicationInfo { get; init; }
        public string? UserName { get; init; }
        public Guid? WorkTaskId { get; init; }
    }
}

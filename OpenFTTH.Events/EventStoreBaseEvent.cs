using System;

namespace OpenFTTH.Events
{
    public abstract record EventStoreBaseEvent
    {
        public DateTime Timestamp { get; init; }
        public Guid? IncitingEventId { get; init; }
        public Guid? IncitingCmdId { get; init; }
        public string? UserName { get; init; }
        public Guid? WorkTaskId { get; init; }
    }
}

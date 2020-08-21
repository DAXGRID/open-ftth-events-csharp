using System;

namespace OpenFTTH.Events
{
    public interface IDomainEvent
    {
        long EventSequenceNumber { get; }
        string EventType { get; }
        Guid EventId { get; }
        DateTime EventTimestamp { get; }
    }
}

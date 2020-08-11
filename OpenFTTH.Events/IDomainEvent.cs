using System;

namespace OpenFTTH.Events
{
    public interface IDomainEvent
    {
        string EventType { get; }
        Guid EventId { get; }
    }
}

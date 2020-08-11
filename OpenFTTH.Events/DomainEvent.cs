using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events
{
    /// <summary>
    /// Mandatory event attributes, that all events in the Open FTTH system must implement
    /// </summary>
    public class DomainEvent : IDomainEvent, IRequest
    {
        private readonly string _eventType;
        public string EventType => _eventType;

        private readonly Guid _eventId;
        public Guid EventId => _eventId;
       
        public DomainEvent(string eventType, Guid eventId)
        {
            _eventType = eventType;
            _eventId = eventId;
        }
    }
}

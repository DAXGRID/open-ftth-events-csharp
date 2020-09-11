using OpenFTTH.Events.Changes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Geo
{
    /// <summary>
    /// Event that represent that some objects, having a geographical location, are updated (added, modified or deleted).
    /// Allows event consumers to refresh maps, caches etc.
    /// </summary>
    public class ObjectsWithinGeographicalAreaUpdated : DomainEvent
    {
        private readonly string _category;
        private readonly EnvelopeInfo _envelope;
        private readonly IdChangeSet[] _idChangeSets;

        /// <summary>
        /// Category of change - i.e. RouteNetworkChanges, AddressChanges, RouteNetworkValidationChanges etc.
        /// Allows the event consumer to more easily filter changes of interest.
        /// </summary>
        public string Category => _category;

        /// <summary>
        /// A bounding box covering the geographical objects that have changed
        /// </summary>
        public EnvelopeInfo Envelope => _envelope;

        /// <summary>
        /// Id changesets, representing what objects that have been added, modified or deleted
        /// </summary>
        public IdChangeSet[] IdChangeSets => _idChangeSets;

        public ObjectsWithinGeographicalAreaUpdated(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, string category, EnvelopeInfo envelope, IdChangeSet[] idChangeSets)
         : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _category = category;
            _envelope = envelope;
            _idChangeSets = idChangeSets;
        }
    }
}

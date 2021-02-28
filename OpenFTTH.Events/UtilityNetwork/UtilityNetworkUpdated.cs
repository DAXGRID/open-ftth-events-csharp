using OpenFTTH.Events.Changes;
using System;

namespace OpenFTTH.Events.UtilityNetwork
{
    /// <summary>
    /// Event representing that some change happend in some equipment possible spanning multiple route network elements
    /// </summary>
    public class RouteNetworkElementContainedEquipmentUpdated : DomainEvent
    {
        private readonly string _category;
        private readonly Guid[] _affectedRouteNetworkElementIds;
        private readonly IdChangeSet[]? _idChangeSets;

        /// <summary>
        /// Category of change - i.e. Conduits, Cables, Terminal Equipment etc.
        /// Allows the event consumer to more easily filter changes of interest.
        /// </summary>
        public string Category => _category;

        public Guid[] AffectedRouteNetworkElementIds => _affectedRouteNetworkElementIds;

        /// <summary>
        /// Id changesets, representing what objects that have been added, modified or deleted
        /// </summary>
        public IdChangeSet[]? IdChangeSets => _idChangeSets;

        public RouteNetworkElementContainedEquipmentUpdated(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, string category, Guid[] affectedRouteNetworkElementIds, IdChangeSet[]? idChangeSets)
         : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo)
        {
            _category = category;
            _affectedRouteNetworkElementIds = affectedRouteNetworkElementIds;
            _idChangeSets = idChangeSets;
        }
    }
}

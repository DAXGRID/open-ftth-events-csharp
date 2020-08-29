using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Changes
{
    /// <summary>
    /// Used to communicate that some change (addition, modification and deletion) happend to some objects, in the form of a simple id list
    /// </summary>
    public class IdChangeSet
    {
        private readonly string _objectType;
        private readonly ChangeTypeEnum _changeType;
        private readonly Guid[] _idList;

        /// <summary>
        /// The type (class name) of the object(s) that have changed
        /// </summary>
        public string ObjectType => _objectType;

        /// <summary>
        /// The type of changes (addition, modfication og deletion) the id list represents
        /// </summary>
        public ChangeTypeEnum ChangeType => _changeType;

        /// <summary>
        /// The list of object ids that have changed
        /// </summary>
        public Guid[] IdList => _idList;

        public IdChangeSet(string objectType, ChangeTypeEnum changeType, Guid[] idList)
        {
            _objectType = objectType;
            _changeType = changeType;
            _idList = idList;
        }
    }
}

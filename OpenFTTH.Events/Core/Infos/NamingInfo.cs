using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core.Infos
{
    public class NamingInfo
    {
        /// <summary>
        /// AKA short name
        /// </summary>
        private readonly string? _name;
        public string? Name => _name;

        private readonly string? _description;

        /// <summary>
        /// AKA long name
        /// </summary>
        public string? Description => _description;

        public NamingInfo(string? name, string? description)
        {
            _name = name;
            _description = description;
        }
    }
}

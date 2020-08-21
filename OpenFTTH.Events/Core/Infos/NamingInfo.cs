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
        public string? Name { get; set; }

        /// <summary>
        /// AKA long name
        /// </summary>
        public string? Description { get; set; }

        public NamingInfo() { }

        public NamingInfo(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
    }
}

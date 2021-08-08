using System;

namespace OpenFTTH.Events.Core.Infos
{
    public class AddressInfo
    {
        /// <summary>
        /// Local or official access address id
        /// </summary>
        public Guid? AccessAddressId { get; set; }

        /// <summary>
        /// Local or official unit address id
        /// </summary>
        public Guid? UnitAddressId { get; set; }

        /// <summary>
        /// Direction information etc.
        /// </summary>
        public string? Remark { get; set; }

        public AddressInfo() { }

        public AddressInfo(Guid? accessAddressId, Guid? unitAddressId, string? remark)
        {
            AccessAddressId = accessAddressId;
            UnitAddressId = unitAddressId;
            Remark = remark;
        }
    }
}

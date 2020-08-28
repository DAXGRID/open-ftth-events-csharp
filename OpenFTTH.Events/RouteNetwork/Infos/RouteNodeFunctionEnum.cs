using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenFTTH.Events.RouteNetwork.Infos
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RouteNodeFunctionEnum
    {
        PrimaryNode, SecondaryNode, FlexPoint, SplicePoint, CustomerPremisesPoint, AccessibleConduitClosure, NonAccessibleConduitClosure
    }
}

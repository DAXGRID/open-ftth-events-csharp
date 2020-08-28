using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenFTTH.Events.RouteNetwork.Infos
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RouteNodeKindEnum
    {
        CentralOfficeBig, 
        CentralOfficeMedium, 
        CentralOfficeSmall, 
        CabinetBig, 
        CabinetSmall, 
        ManHole, 
        HandHole, 
        ConduitClosure, 
        ConduitClosureStraight, 
        ConduitClosureFork, 
        ConduitClosureBranchOff, 
        ConduitConnector, 
        ConduitConnectorStraight, 
        ConduitConnectorBranchOff, 
        ConduitEnd, 
        SpliceClosure, 
        BuildingAccessPoint, 
        MultiDwellingUnit, 
        SingleDwellingUnit
    }
}

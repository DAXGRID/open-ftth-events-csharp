using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork.Infos
{
    public class RouteNodeInfo
    {
        public RouteNodeKindEnum? Kind { get; set; }
        public RouteNodeFunctionEnum? Function { get; set; }

        public RouteNodeInfo() { }

        public RouteNodeInfo(RouteNodeKindEnum? kind, RouteNodeFunctionEnum? function)
        {
            Kind = kind;
            Function = function;
        }
    }
}

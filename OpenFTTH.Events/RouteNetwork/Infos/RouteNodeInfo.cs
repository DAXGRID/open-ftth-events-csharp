using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork.Infos
{
    public class RouteNodeInfo
    {
        private readonly RouteNodeKindEnum? _kind;
        public RouteNodeKindEnum? Kind => _kind;


        private readonly RouteNodeFunctionEnum? _function;
        public RouteNodeFunctionEnum? Function => _function;


        public RouteNodeInfo(RouteNodeKindEnum kind, RouteNodeFunctionEnum function)
        {
            _kind = kind;
            _function = function;
        }
    }
}

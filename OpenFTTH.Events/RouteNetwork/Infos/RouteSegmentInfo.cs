using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork.Infos
{
    public class RouteSegmentInfo
    {
        private readonly RouteSegmentKindEnum? _kind;
        public RouteSegmentKindEnum? Kind => _kind;

        private readonly string? _width;
        public string? Width => _width;

        private readonly string? _height;
        public string? Height => _height;

        public RouteSegmentInfo() { }

        public RouteSegmentInfo(RouteSegmentKindEnum? kind, string? width, string? height)
        {
            _kind = kind;
            _width = width;
            _height = height;
        }
    }
}

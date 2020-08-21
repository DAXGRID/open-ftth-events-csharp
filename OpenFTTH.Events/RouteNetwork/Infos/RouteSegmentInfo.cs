using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork.Infos
{
    public class RouteSegmentInfo
    {
        public RouteSegmentKindEnum? Kind { get; set; }
        public string? Width { get; set; }
        public string? Height { get; set; }
        public RouteSegmentInfo() { }

        public RouteSegmentInfo(RouteSegmentKindEnum? kind, string? width, string? height)
        {
            Kind = kind;
            Width = width;
            Height = height;
        }
    }
}

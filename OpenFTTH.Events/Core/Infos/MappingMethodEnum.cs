using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenFTTH.Events.Core.Infos
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MappingMethodEnum
    {
        Drafting, Schematic, LandSurveying, DigitizedFromPaperMaps, Imagery, Sensor, Other
    }
}

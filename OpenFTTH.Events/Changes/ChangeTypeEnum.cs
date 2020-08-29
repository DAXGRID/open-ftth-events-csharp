using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenFTTH.Events.Changes
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ChangeTypeEnum
    {
        Addition,
        Modification,
        Deletion
    }
}

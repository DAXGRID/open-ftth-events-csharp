using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenFTTH.Events.Core.Infos
{
    public enum DeploymentStateEnum
    {
        NotYetInstalled, Installed, InService, OutOfService, Removed
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core.Infos
{
    public class LifecycleInfo
    {
        public DeploymentStateEnum? DeploymentState { get; set; }
        public DateTime? InstallationDate { get; set; }
        public DateTime? RemovalDate { get; set; }

        public LifecycleInfo() { }

        public LifecycleInfo(DeploymentStateEnum? deploymentState, DateTime? installationDate, DateTime? removalDate)
        {
            DeploymentState = deploymentState;
            InstallationDate = installationDate;
            RemovalDate = removalDate;
        }
    }
}

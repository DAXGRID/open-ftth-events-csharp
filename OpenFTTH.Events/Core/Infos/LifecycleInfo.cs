using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core.Infos
{
    public class LifecycleInfo
    {
        private readonly DeploymentStateEnum? _deploymentState;
        public DeploymentStateEnum? DeploymentState => _deploymentState;

        private readonly DateTime? _installationDate;
        public DateTime? InstallationDate => _installationDate;

        private readonly DateTime? _removalDate;
        public DateTime? RemovalDate => _removalDate;

        public LifecycleInfo() { }

        public LifecycleInfo(DeploymentStateEnum? deploymentState, DateTime? installationDate, DateTime? removalDate)
        {
            _deploymentState = deploymentState;
            _installationDate = installationDate;
            _removalDate = removalDate;
        }
    }
}

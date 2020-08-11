using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core.Infos
{
    public class LifecyleInfo
    {
        private readonly DeploymentStateEnum? _deploymentState;
        public DeploymentStateEnum? DepploymentState => _deploymentState;

        private readonly DateTime? _installationDate;
        public DateTime? InstallationDate => _installationDate;

        private readonly DateTime? _removalDate;
        public DateTime? RemovalDate => _removalDate;

        public LifecyleInfo(DeploymentStateEnum? deploymentState, DateTime? installationDate, DateTime? removalDate)
        {
            _deploymentState = deploymentState;
            _installationDate = installationDate;
            _removalDate = removalDate;
        }
    }
}

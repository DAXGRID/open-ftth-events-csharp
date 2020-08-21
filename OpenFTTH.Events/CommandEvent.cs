using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events
{
    /// <summary>
    /// An event resulted from a command.
    /// Typical a user triggered command of some kind, but can also be a system triggered command.
    /// </summary>
    public class CommandEvent : DomainEvent
    {
        private readonly string _cmdType;
        public string CmdType => _cmdType;

        private readonly Guid _cmdId;
        public Guid CmdId => _cmdId;

        private readonly bool _isLastEventInCmd;
        public bool IsLastEventInCmd => _isLastEventInCmd;

        private readonly Guid? _workTaskMrid;
        public Guid? WorkTaskMrid => _workTaskMrid;

        private readonly string? _userName;
        public string? UserName => _userName;

        private readonly string? _applicationName;
        public string? ApplicationName => _applicationName;

        private readonly string? _applicationInfo;
        public string? ApplicationInfo => _applicationInfo;

        public CommandEvent(string eventType, Guid eventId, DateTime eventTimestamp, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid? workTaskMrid, string? userName, string? applicationName, string? applicationInfo) : base(eventType, eventId, eventTimestamp)
        {
            _cmdType = cmdType;
            _cmdId = cmdId;
            _isLastEventInCmd = isLastEventInCmd;
            _workTaskMrid = workTaskMrid;
            _userName = userName;
            _applicationName = applicationName;
            _applicationInfo = applicationInfo;
        }
    }
}

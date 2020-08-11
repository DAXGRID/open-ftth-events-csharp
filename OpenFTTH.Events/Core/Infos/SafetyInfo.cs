using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core.Infos
{
    public class SafetyInfo
    {
        private readonly string? _classification;
        public string? Classification => _classification;

        private readonly string? _remark;
        public string? Remark => _remark;

        public SafetyInfo(string? classification, string? remark)
        {
            _classification = classification;
            _remark = remark;
        }
    }
}

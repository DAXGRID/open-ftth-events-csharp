using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core.Infos
{
    public class SafetyInfo
    {
        public string? Classification { get; set; }
        public string? Remark { get; set; }

        public SafetyInfo() { }

        public SafetyInfo(string? classification, string? remark)
        {
            Classification = classification;
            Remark = remark;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core.Infos
{
    public class MappingInfo
    {
        public MappingMethodEnum? Method { get; set; }
        public string? VerticalAccuracy { get; set; }
        public string? HorizontalAccuracy { get; set; }
        public DateTime? SurveyDate { get; set; }
        public string? SourceInfo { get; set; }

        public MappingInfo() {}

        public MappingInfo(MappingMethodEnum? method, string? verticalAccuracy, string? horizontalAccuracy, DateTime? surveyDate, string? sourceInfo)
        {
            Method = method;
            VerticalAccuracy = verticalAccuracy;
            HorizontalAccuracy = horizontalAccuracy;
            SurveyDate = surveyDate;
            SourceInfo = sourceInfo;
        }
    }
}

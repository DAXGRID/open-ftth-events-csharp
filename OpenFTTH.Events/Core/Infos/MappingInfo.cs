using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core.Infos
{
    public class MappingInfo
    {
        private readonly MappingMethodEnum? _method;
        public MappingMethodEnum? Method => _method;

        private readonly string? _verticalAccuracy;
        public string? VerticalAccuracy => _verticalAccuracy;

        private readonly string? _horizontalAccuracy;
        public string? HorizontalAccuracy => _horizontalAccuracy;

        private readonly DateTime? _surveyDate;
        public DateTime? SurveyDate => _surveyDate;

        private readonly string? _sourceInfo;
        public string? SourceInfo => _sourceInfo;


        public MappingInfo(MappingMethodEnum? method, string? verticalAccuracy, string? horizontalAccuracy, DateTime? surveyDate, string? sourceInfo)
        {
            _method = method;
            _verticalAccuracy = verticalAccuracy;
            _horizontalAccuracy = horizontalAccuracy;
            _surveyDate = surveyDate;
            _sourceInfo = sourceInfo;
        }
    }
}

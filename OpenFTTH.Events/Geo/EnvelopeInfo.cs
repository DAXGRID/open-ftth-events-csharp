using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Geo
{
    /// <summary>
    /// Geographical bounding box - aka envelope and boundary 
    /// </summary>
    public class EnvelopeInfo
    {
        private readonly double _minX;
        public double MinX => _minX;

        private readonly double _maxX;
        public double MaxX => _maxX;

        private readonly double _minY;
        public double MinY => _minY;

        private readonly double _maxY;
        public double MaxY => _maxY;

        public EnvelopeInfo(double minX, double maxX, double minY, double maxY)
        {
            _minX = minX;
            _maxX = maxX;
            _minY = minY;
            _maxY = maxY;
        }
    }
}

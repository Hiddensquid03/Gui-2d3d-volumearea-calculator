using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    internal class Ellipsoid :CalcVolume
    {
        private double Depth, Length, Width;
        public Ellipsoid( double depth,double length, double width)
        {
            this.Length = length;
            this.Width = width;
            this.Depth = depth;

        }
        public double Volume()
        {
            return (4.0/3.0) * Math.PI * Length * Width;
        }
    }
}

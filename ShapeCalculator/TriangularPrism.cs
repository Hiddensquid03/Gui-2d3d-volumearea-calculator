using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    internal class TriangularPrism : CalcVolume
    {
        private double Depth, Length, Width;
        public TriangularPrism(double depth, double length, double width)
        {
            this.Length = length;
            this.Width = width;
            this.Depth = depth;

        }
        public double Volume()
        {
            return (Width * Length *0.5) * Depth;
        }
    }
}

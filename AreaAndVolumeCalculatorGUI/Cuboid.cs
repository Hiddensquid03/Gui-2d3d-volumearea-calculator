using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndVolumeCalculatorGUI
{
    internal class Cuboid :CalcVolume
    {
        private double Depth, Length, Width;
        public Cuboid(double depth, double length, double width)
        {
            this.Length = length;
            this.Width = width;
            this.Depth = depth;

        }
        public double Volume()
        {
            return Depth * Length * Width;
        }
    }
}

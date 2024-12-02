using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndVolumeCalculatorGUI
{
    internal class Triangle : CalcArea
    {
        private double Length, Height;
        public Triangle(double length, double height)
        {
            this.Length = length;
            this.Height = height;

        }
        public double Area()
        {
            return Length * Height / 2;
        }
    }
}

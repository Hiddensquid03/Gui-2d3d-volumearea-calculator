using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndVolumeCalculatorGUI
{


    internal class Rectangle : CalcArea
    {
        private double Length, Height;
        public Rectangle(double length, double height)
        {
            this.Length = length;
            this.Height = height;

        }
        public double Area()
        {
            return Length * Height;
            }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    internal class Elipse :CalcArea
    {
        private double Length, Height;
        public Elipse (double length, double height)
        {
            this.Length = length;
            this.Height = height;
            
        }
        public double Area()
        {
            return Math.PI * Length * Height;
        }
    }
}

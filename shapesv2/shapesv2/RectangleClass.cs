using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double length;
        public override string ShapeName { get; }
        public Rectangle()
        {
            ShapeName = "Rectangle";
        }

        public override void RequestDimensions()
        {
            RequestDimensionValue("width", out double Lwidth);
            RequestDimensionValue("length", out double Llength);
            width = Lwidth;
            length = Llength;
        }
        public override double CalculateArea()
        {
            double Result = length * width;
            return Result;
        }
        public override double CalculatePerimeter()
        {
            double Result = (2 * length) + (2 * width); 
            return Result;
        }
    }
}

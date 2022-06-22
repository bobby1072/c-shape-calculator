using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double diameter;
        private double radius;

        public override string ShapeName { get; }
        public Circle()
        {
            ShapeName = "Circle";
        }
        public void GetRadius()
        {
            radius = diameter / 2;
        }
        public override void RequestDimensions()
        {
            RequestDimensionValue("diameter", out double Ldiameter);
            diameter = Ldiameter;
        }
        public override double CalculateArea()
        {
            double Result = Math.PI * diameter;
            return Result;
        }
        public override double CalculatePerimeter()
        {
            double Result = Math.PI * ((diameter / 2) * (diameter / 2));
            return Result;
        }
    }
}
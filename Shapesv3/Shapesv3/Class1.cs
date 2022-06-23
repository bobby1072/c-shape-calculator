using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesv3
{
    public class Circle : Shape
    {
        private double _diameter;

        public override string ShapeName { get; }

        public Circle()
        {
            ShapeName = "Circle";

            _diameter = 0;
        }

        public override void SetDimensions(params double[] dimensions)
        {
            _diameter = dimensions[0];
        }

        public override double CalculateArea()
        {
            double Result = Math.PI * ((_diameter / 2) * (_diameter / 2));
            return Result;
        }
        public override double CalculatePerimeter()
        {
            double Result = Math.PI * _diameter;
            return Result;
        }
    }
}
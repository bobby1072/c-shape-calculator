using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesv3
{
    public class Triangle : Shape
    {
        private double _base;

        private double _height;

        public override string ShapeName { get; }
        public Triangle()
        {
            ShapeName = "Triangle";
        }

        public void SetDimensions(double @base, double height)
        {
            SetDimensions(new[] { @base, height });
        }

        protected override void SetDimensions(params double[] dimensions)
        {
            _base = dimensions[0];
            _height = dimensions[1];
        }

        public override double CalculateArea()
        {
            double Result = (_base * _height / 2);
            return Result;
        }
        public override double CalculatePerimeter()
        {
            double Result = (_base * 3);
            return Result;
        }
    }
}

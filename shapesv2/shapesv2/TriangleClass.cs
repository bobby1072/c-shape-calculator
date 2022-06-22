using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private double basse;
        private double height;
        public override string ShapeName { get; }
        public Triangle()
        {
            ShapeName = "Triangle";
        }

        public override void RequestDimensions()
        {
            RequestDimensionValue("base", out double Lbase);
            RequestDimensionValue("height", out double Lheight);
            basse = Lbase;
            height = Lheight;
        }
        public override double CalculateArea()
        {
            double Result = (double)(basse * height / 2);
            return Result;
        }
        public override double CalculatePerimeter()
        {
            double Result = (double)(basse * 3);
            return Result;
        }
    }
}

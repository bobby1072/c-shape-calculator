using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesv3
{
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }
        public override string ShapeName { get; }
        public Rectangle()
        {
            ShapeName = "Rectangle";
        }

        public override void SetDimensions(params double[] dimensions)
        {
            width = dimensions[0];
            height = dimensions[1];
        }

        public override double CalculateArea()
        {
            double Result = width * height;
            return Result;
        }

        public override double CalculatePerimeter()
        {
            double Result = (2 * width) + (2 * height);
            return Result;
        }
    }
}
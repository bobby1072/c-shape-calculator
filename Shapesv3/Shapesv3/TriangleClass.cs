using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesv3
{
    public class Triangle : Shape
    {
        public override double BaseWidth { get; set; }
        public override double LenHeightDie { get; set; }
        public override string ShapeName { get; }
        public Triangle()
        {
            ShapeName = "Triangle";
        }
        public override double CalculateArea()
        {
            double Result = (double)(BaseWidth * LenHeightDie / 2);
            return Result;
        }
        public override double CalculatePerimeter()
        {
            double Result = (double)(BaseWidth * 3);
            return Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesv3
{
    public class Rectangle : Shape
    {
        public override double BaseWidth { get; set; }
        public override double LenHeightDie { get; set; }
        public override string ShapeName { get; }
        public Rectangle()
        {
            ShapeName = "Rectangle";
        }
        public override double CalculateArea()
        {
            double Result = LenHeightDie * BaseWidth;
            return Result;
        }
        public override double CalculatePerimeter()
        {
            double Result = (2 * LenHeightDie) + (2 * BaseWidth);
            return Result;
        }
    }
}
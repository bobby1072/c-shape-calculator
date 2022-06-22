using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesv3
{
    public class Circle : Shape
    {
        public override double BaseWidth { get; set; }
        public override double LenHeightDie { get; set; }
        public override string ShapeName { get; }
        public Circle()
        {
            ShapeName = "Circle";
            BaseWidth = 0;
        }
        public override double CalculateArea()
        {
            double Result = Math.PI * ((LenHeightDie / 2) * (LenHeightDie / 2));
            return Result;
        }
        public override double CalculatePerimeter()
        {
            double Result = Math.PI * LenHeightDie;
            return Result;
        }
    }
}
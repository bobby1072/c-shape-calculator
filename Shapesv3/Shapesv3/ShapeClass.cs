using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesv3
{
    public abstract class Shape
    {
        public abstract string ShapeName { get; }
        protected abstract void SetDimensions(params double[] dimensions);
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

    }
}
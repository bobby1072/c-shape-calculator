using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract string ShapeName { get; }
        public abstract void RequestDimensions();
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public double RequestDimensionValue(string DimensionName, out double DimensionValue)
        {
            var userInput = "init";
            while (!double.TryParse(userInput, out DimensionValue))
            {
                Console.WriteLine();

                if (userInput != "init")
                {
                    Console.WriteLine("Please enter a number. ");
                }
                Console.Write($"What is the shape's {DimensionName}? ");
                userInput = Console.ReadLine();
            }
            return DimensionValue;
        }

    }
}

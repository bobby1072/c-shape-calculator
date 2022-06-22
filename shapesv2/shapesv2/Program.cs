using System;
namespace Shapes
{
    public class Program
    {
        public static string Capitalise(string nonCappedINP)
        {
            return nonCappedINP.Substring(0,1).ToUpper() + nonCappedINP.Substring(1);
        }
        public static string RequestShapeName()
        {
            string[] AvailableShapes = { "triangle", "rectangle", "circle" };
            string shapeName = "null";
            while (!AvailableShapes.Contains(shapeName))
            {
                if (shapeName != "null")
                {
                    Console.Write("Please enter a valid shape.");
                    Console.WriteLine();
                }
                Console.Write("Please enter the shape you would like to use: ");
                shapeName = Console.ReadLine();
                shapeName = shapeName.ToLower();

            }
            return Capitalise(shapeName);
        }
        public static Shape Create(string shapeName)
        {
            var type = Type.GetType(typeof(Shape).Namespace + "." + shapeName, throwOnError: false);
            return (Shape)Activator.CreateInstance(type);
        }
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("This program will allow you to perform calculation on 2D shapes ( Equalateral triangles, rectangles and circles)");
                Console.WriteLine("When using this application make sure that to keep the units used the same for each dimension entered.");
                Console.WriteLine();
                string userNameInp = RequestShapeName();
                var mainShape = Create(userNameInp);    
                mainShape.RequestDimensions();
                Console.WriteLine();
                Console.WriteLine($"The perimeter is {mainShape.CalculatePerimeter()}");
                Console.WriteLine($"The area is {mainShape.CalculateArea()}");
                Console.WriteLine();
            }
        }
    }
}
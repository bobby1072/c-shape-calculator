using System;
using System.Threading;
namespace shapers
{
    class program
    {
        static void man_pro()
        {
            Console.WriteLine("This program will allow you to perform calculation on 2D shapes (triangles, rectangles and circles)\nWhen using this application make sure that to keep the units used the same for each dimension entered.\nPlease enter the name of the shape you would like to perform a calulation on:\n");
            string shape_name = Console.ReadLine();
            Shape top_shape = new Shape();
            top_shape.shapename = shape_name;
            if (top_shape.shapename.ToLower() == "triangle")
            {
                Console.WriteLine("\n\nPlease enter the height of the triangle:\n");
                float user_tri_height = float.Parse(Console.ReadLine());
                Console.WriteLine("\n\nPlease enter the base of the triangle:\n");
                float user_tri_base = float.Parse(Console.ReadLine());
                triangle user_tri = new triangle();
                user_tri.shapename = "triangle";
                user_tri.height = user_tri_height;
                user_tri.basse = user_tri_base;
                user_tri.tri_area();
                Console.WriteLine($"\n\nThe area of the triangle is {user_tri.area}");
            }
            else if (top_shape.shapename.ToLower() == "rectangle")
            {
                Console.WriteLine("\n\nPlease enter the width of the rectangle:\n");
                float user_rec_width = float.Parse(Console.ReadLine());
                Console.WriteLine("\n\nPlease enter the length of the rectangle:\n");
                float user_rec_length = float.Parse(Console.ReadLine());
                rectangle user_rec = new rectangle();
                user_rec.shapename = "rectangle";
                user_rec.width = user_rec_width;
                user_rec.length = user_rec_length;
                user_rec.rec_area();
                user_rec.rec_perim();
                Console.WriteLine($"\n\nThe perimeter of your rectangle is {user_rec.perimeter} and the area is {user_rec.area}");
            }
            else if (top_shape.shapename.ToLower() == "circle")
            {
                Console.WriteLine("\n\nPlease enter the diameter of the circle:\n");
                double user_circ_diameter = double.Parse(Console.ReadLine());
                circle user_circ = new circle();
                user_circ.shapename = "circle";
                user_circ.diameter = user_circ_diameter;
                user_circ.circ_area();
                user_circ.circ_cumferen();
                Console.WriteLine($"The area of your circle is {user_circ.area} and the circumference is {user_circ.circumference}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\nPlease enter a valid shape.\n\n");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

        }
        static void Main(string[] args)
        {
            man_pro();
        }
    }
}
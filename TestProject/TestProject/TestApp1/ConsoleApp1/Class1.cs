using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        myClass myObject = new myClass();
        {
        using System;
        class Shape
        {
            public string Type;
            public int Sides;
            public int Sidelength;
            public double Area;
            public Shape(string type, int sides, int sidelength, double area)
            {
                Type = type;
                Sides = sides;
                Sidelength = sidelength;
                Area = area;
            }
        }
        class MainClass
        {
            public static void Main()
            {
                Shape square = new Shape("square", 4, 1, 1);
                Shape bigsquare = new Shape("square", 4, 2, 4);
                Shape triangle = new Shape("triangle", 3, 3, 3.9);
                Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", square.Type, square.Sides, square.Sidelength, square.Area);
                Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", bigsquare.Type, bigsquare.Sides, bigsquare.Sidelength, bigsquare.Area);
                Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", triangle.Type, triangle.Sides, triangle.Sidelength, triangle.Area);
            }
        
        }
    }
}

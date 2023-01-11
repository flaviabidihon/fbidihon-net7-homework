using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise3
{
    public class Circle : Shape
    {
        public override string Color { get; set; }
        public double Radius { get; set; }

        public Circle(string color, double radius)
        {
            Color = color;
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public string GetPerimeter(string unit)
        {
            Console.WriteLine("Insert unit of measurement: ");
            unit = Console.ReadLine();
            return $"Circumference: {GetPerimeter()} {unit}";
        }
    }
}

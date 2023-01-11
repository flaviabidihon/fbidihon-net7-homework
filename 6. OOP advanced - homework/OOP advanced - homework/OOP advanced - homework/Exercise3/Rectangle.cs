using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise3
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override string Color { get; set; }

        public Rectangle(string color, double width, double height)
        {
            Color = color;
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
        
        public string GetPerimeter(string unit)
        {
            Console.WriteLine("Insert unit of measurement: ");
            unit = Console.ReadLine();
            return $"Perimeter: {GetPerimeter()} {unit}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise6
{
    public class Rectangle2 : IShape, IColor
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public string Color { get; set; }

        public Rectangle2(double width, double height)
        {
            Width = width;
            Height = height;
            Color = "Black";
        }

        public Rectangle2(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public string CalculateArea(string txt)
        {
            return $"Area: {CalculateArea()} {txt}";
        }
    }
}

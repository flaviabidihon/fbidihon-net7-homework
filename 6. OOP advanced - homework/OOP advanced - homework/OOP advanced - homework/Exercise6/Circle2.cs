using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_advanced___homework.Exercise6
{
    public class Circle2 : IShape, IColor
    {
        private double Radius { get; set; }
        public string Color { get; set; }


        public Circle2(double radius)
        {
            Radius = radius;
            Color = "Black";
        }

        public Circle2(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public string CalculateArea(string txt)
        {
            return $"Area: {CalculateArea()} {txt}";
        }
    }
}

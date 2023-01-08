using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise3
{
    public abstract class Shape
    {
        public virtual string Color { get; set; }
        public virtual double Area { get; set; } = 0;

        //public Shape(string color, double area)
        //{
        //    Color = color;
        //    Area = area;
        //}

        public abstract double CalculateArea();
        public virtual double GetPerimeter()
        {
            return 0;
        }
        
    }
}

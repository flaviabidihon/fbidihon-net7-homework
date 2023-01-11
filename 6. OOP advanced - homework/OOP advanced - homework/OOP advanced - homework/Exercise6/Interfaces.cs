using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise6
{
    public interface IShape
    {
        string CalculateArea(string v);
        double CalculateArea();
    }


    public interface IColor
    {
        string Color { get; set; }
    }
}

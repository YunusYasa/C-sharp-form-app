using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Open_Closeed_Principle
{
    public class Rectangle:Shapes
    {
        public double Widght { get; set; }
        public double Height { get; set; }

        public Rectangle(double widght, double height)
        {
            Widght = widght;
            Height = height;
        }
        public override double Area()
        {
            return Widght*Height;
        }
    }
}

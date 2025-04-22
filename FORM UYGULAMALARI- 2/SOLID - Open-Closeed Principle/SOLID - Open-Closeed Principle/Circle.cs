using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Open_Closeed_Principle
{
    public class Circle:Shapes
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Open_Closeed_Principle
{
    internal class Square:Shapes
    {
        public int Line { get; set; }

        public  Square(int line)
        {
            Line = line;
        }

        public override double Area()
        {
            return Line * Line;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Open_Closeed_Principle
{
    public partial class AreaCalculator
    {
        public double Area(Shapes [] shapes)
        {
            double areas = 0;
            foreach (var shape in shapes)
            {
                areas += shape.Area();
            }

            return areas;
        }
    }
}

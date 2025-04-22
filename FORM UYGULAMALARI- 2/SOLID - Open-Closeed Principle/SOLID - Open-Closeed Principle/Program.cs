using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Open_Closeed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(15, 10);
            Console.WriteLine(rc.Area());

            Circle c = new Circle(10);
            Console.WriteLine(c.Area());

            Square s = new Square(10);
            Console.WriteLine(s.Area());    

            Console.ReadLine();

        }
    }
}

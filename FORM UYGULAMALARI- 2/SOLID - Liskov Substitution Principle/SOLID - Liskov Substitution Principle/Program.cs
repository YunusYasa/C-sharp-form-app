using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Liskov_Substitution_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Volvo v = new Volvo();
            Console.WriteLine(v.Start());
            Console.WriteLine(v.klima());

            Mercedes m = new Mercedes();
            Console.WriteLine(m.Start());
            Console.WriteLine(m.klima());

            Toros t = new Toros();
            Console.WriteLine(t.Start());
           
            Console.Read();
        }
    }
}

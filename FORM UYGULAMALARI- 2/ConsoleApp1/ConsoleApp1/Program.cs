using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y ;

            x = 1;
            y = 2;
           int z = x + y;
            x = y;
            int v = x + y;

            Console.WriteLine(z+"  "+x+"  "+v);
            Console.ReadLine();
        }
    }
}

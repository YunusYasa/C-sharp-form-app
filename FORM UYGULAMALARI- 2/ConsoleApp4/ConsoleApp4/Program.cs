using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 200; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    i++;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

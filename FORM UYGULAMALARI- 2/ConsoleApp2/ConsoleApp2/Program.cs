using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int c1 = 0;
            int c2 = 0;
            bool deneme = true;        

            Console.WriteLine("a ve b gir");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            string d = Convert.ToString(b);
          

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);

                for (int j = 0; j < d.Length; j++)
                {
                    Console.WriteLine(i); 
                    c = i % 10;
                    i = i / 10;
                    c1 = i % 10;
                    
                }
                Console.WriteLine(i);
                if (deneme == true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}

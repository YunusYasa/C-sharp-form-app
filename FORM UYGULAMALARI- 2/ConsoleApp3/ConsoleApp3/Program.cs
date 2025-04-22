using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool deneme = true;

            for (int i = 100; i < 200; i++)
            {
                int number = i;
                for (int j = 0; j < 2; j++)
                {
                    
                    int sayi = number % 10;
                    number /= 10;
                    int sayi2 = number % 10;

                    if (sayi2+1 == sayi )
                    {
                        deneme = true;
                    }
                    else
                    {
                        deneme = false;
                        break;
                    }
                }
              
                if (deneme == true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            
        }
    }
}

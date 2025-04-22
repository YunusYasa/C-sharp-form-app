using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Single_Responsibilty
{
    internal class EmployeeProcess
    {
        public void Process() 
        {
            Console.WriteLine("*** Single Resposibility Principle Example ***");
            Console.BackgroundColor = ConsoleColor.Green;
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}

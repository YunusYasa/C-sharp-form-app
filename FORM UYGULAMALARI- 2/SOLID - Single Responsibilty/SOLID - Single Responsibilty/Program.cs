using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Single_Responsibilty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeCrud employeeCrud = new EmployeeCrud();
            employeeCrud.EmployeeList();
            EmployeeDef employeeDef = new EmployeeDef();
            employeeDef.Name = "Alii";
            employeeDef.Surname = "Velii";
            employeeCrud.EmployeeAdd(employeeDef);
            EmployeeProcess employeeProcess = new EmployeeProcess();
            employeeProcess.Process();
            employeeCrud.EmployeeList();




            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Liskov_Substitution_Principle
{
    internal class Volvo:Araba,IKlima
    {
        public string klima()
        {
            return "Volvo'nun klima çalıştı";
        }
    }
}

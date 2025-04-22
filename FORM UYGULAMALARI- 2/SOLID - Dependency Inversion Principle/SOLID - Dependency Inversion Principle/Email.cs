using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Dependency_Inversion_Principle
{
    internal class Email:IMessage
    {
        public string ToAdress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Yeni mesaj geldi");
            Console.WriteLine("Kimden : " + ToAdress + " Mesaj : " + Subject + " Konu : " + Content);
        }
    }
}

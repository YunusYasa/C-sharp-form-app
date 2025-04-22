using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Dependency_Inversion_Principle
{
    internal class Whatsapp:IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public char Emoji { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Yeni mesaj geldi");
            Console.WriteLine("Kimden : " + PhoneNumber + "Mesaj : " + Message + "Emoji : " + Emoji);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Subject = "Test**";
            email.Content = "Test99";
            email.ToAdress = "Test";
            email.SendMessage();
            Sms sms = new Sms();
            sms.Message = "Test";
            sms.PhoneNumber = "1237";
            sms.SendMessage();
            Whatsapp whatsapp = new Whatsapp();
            whatsapp.Message = "Test";
            whatsapp.PhoneNumber = "12345";
            whatsapp.Emoji = ')';
            whatsapp.SendMessage();

            Console.Read();
        }
    }
}

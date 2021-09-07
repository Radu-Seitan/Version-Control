using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.ProxyPattern;

namespace ConsoleApp.DecoratorPattern
{
    class RegistrationMessage : IMessage
    {
        public void GetMessage()
        {
            Console.WriteLine("Register your account");
            var registrationHandler = new ProxyUserRegistration();
            registrationHandler.RegisterUser();
        }
    }
}

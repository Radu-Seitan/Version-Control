using ConsoleApp.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.FacadePattern
{
    class RegisterServiceFacade
    {
        private RegistrationMessage _register;

        public RegisterServiceFacade()
        {
            _register = new();
        }

        public void Register()
        {
            new SuccesDecorator(new AlertDecorator(_register)).GetMessage();
        }
    }
}

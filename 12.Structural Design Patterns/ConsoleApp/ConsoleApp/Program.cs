using ConsoleApp.FacadePattern;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var registerUI = new RegisterServiceFacade();
            registerUI.Register();
        }
    }
}

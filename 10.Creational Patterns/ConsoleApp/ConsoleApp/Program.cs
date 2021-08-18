using ConsoleApp.Interfaces;
using ConsoleApp.Messages;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryControllerSingleton.Instance.CreateMessage();
        }
    }
}

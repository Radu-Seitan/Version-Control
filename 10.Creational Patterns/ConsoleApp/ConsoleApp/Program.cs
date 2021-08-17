using ConsoleApp.Interfaces;
using ConsoleApp.Messages;
using ConsoleApp.Factories;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageFactory factory = null;

            Console.WriteLine("What message would you like to send?");
            string option = Console.ReadLine();

            switch(option.ToLower())
            {
                case "short":
                    factory = new ShortMessageFactory();
                    break;
                case "normal":
                    factory = new NormalMessageFactory();
                    break;
                case "long":
                    factory = new LongMessageFactory();
                    break;
            }

            IMessage message = factory.CreateMessage();
            Console.WriteLine(message.GetMessage());
        }
    }
}

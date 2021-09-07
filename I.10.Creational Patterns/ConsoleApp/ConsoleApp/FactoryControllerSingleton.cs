using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Factories;
using ConsoleApp.Interfaces;

namespace ConsoleApp
{
    public sealed class FactoryControllerSingleton
    {
        private static readonly Lazy<FactoryControllerSingleton> _lazyVariable = new(() => new FactoryControllerSingleton(), true);

        public static FactoryControllerSingleton Instance
        {
            get
            {
                return _lazyVariable.Value;
            }
        }

        private FactoryControllerSingleton()
        {

        }

        public void CreateMessage()
        {
            IMessageFactory factory = null;

            Console.WriteLine("What message would you like to send?");
            string option = Console.ReadLine();

            switch (option.ToLower())
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

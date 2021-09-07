using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DecoratorPattern
{
    class AlertDecorator : MessageDecorator
    {
        public AlertDecorator(IMessage wrappedMessage) : base(wrappedMessage)
        {

        }
        public override void GetMessage()
        {
            Console.WriteLine("Attention! You have a high prority message");
            base.GetMessage();
        }
    }
}
